using MongoDB.Driver;
using Vim.Math3d;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.BinOut.Scene.Point;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;
using static Weedwacker.GameServer.Systems.Script.Scene.SceneGroup;

namespace Weedwacker.GameServer.Systems.World
{
    internal class Scene
    {
        public readonly World World;
        public readonly SceneData SceneData;
        public readonly List<Player.Player> Players = new();
        public readonly Dictionary<uint, GameEntity> Entities = new(); // entityId
        public readonly HashSet<SpawnInfo> SpawnedEntities;
        public readonly HashSet<SpawnInfo> DeadSpawnedEntities;
        public int AutoCloseTime;
        public uint Time { get; private set; }
        public SceneScriptManager ScriptManager { get; private set; }
        public readonly ScenePointData PointData;
        public readonly DungeonData? DungeonData;
        public int PrevScene; // Id of the previous scene
        public int PrevScenePoint;
        public Dictionary<Tuple<int, int>, int> ActiveAreaWeathers; // <areaID1, areaID2> weatherId>
        public HashSet<uint> SceneTags; // TODO apply based on host's data
        public Scene(World world, SceneData sceneData)
        {
            World = world;
            SceneData = sceneData;
            PointData = GameData.ScenePointDataMap["scene" + sceneData.id + "_point"];
            if (sceneData.type == SceneType.SCENE_DUNGEON)
                DungeonData = GameData.DungeonDataMap.Where(w => w.Value.sceneId == sceneData.id).First().Value;

            Time = 8 * 60;
            PrevScene = 3;

            //TODO
            SceneTags = new HashSet<uint>(GameData.SceneTagDataMap.Where(w => w.Value.sceneId == GetId()).Select(s => (uint)s.Key));

            //ScriptManager = GameData.SceneScripts[GetId()];
        }

        public int GetId()
        {
            return SceneData.id;
        }
        public GameEntity GetEntityById(uint id)
        {
            return Entities[id];
        }

        public void ChangeTime(int time)
        {
            Time = (uint)time % 1440;
        }

        public bool IsInScene(GameEntity entity)
        {
            return Entities.ContainsKey(entity.Id);
        }

        public async Task UpdateActiveAreaWeathersAsync(Tuple<int, int> areaIDs)
        {
            //TODO update based on host's weather and quest progression
            await BroadcastPacketAsync(new PacketSceneAreaWeatherNotify(ClimateType.CLIMATE_SUNNY, 1));
        }

        public async Task AddPlayerAsync(Player.Player player, EnterReason reason, Vector3 newPosition, EnterType type = EnterType.Self, int oldSceneId = default, Vector3 oldPos = default)
        {
            // Check if player already in
            if (Players.Contains(player))
            {
                return;
            }

            // Add
            Players.Add(player);
            await player.SetSceneAsync(this);
            player.Position = newPosition;

            // Update Database
            var filter = Builders<Player.Player>.Filter.Where(w => w.AccountUid == player.AccountUid);
            var update = Builders<Player.Player>.Update.Set(w => w.PositionArray, player.PositionArray).Set(w => w.RotationArray, player.RotationArray);
            await DatabaseManager.UpdatePlayerAsync(filter, update);

            await player.SendPacketAsync(new PacketPlayerEnterSceneNotify(player, type, reason, this, newPosition, oldSceneId, oldPos));

            await SetupPlayerAvatarsAsync(player);
        }

        public async Task RemovePlayerAsync(Player.Player player, bool dontDestroyWhenEmpty = false)
        {
            // Remove player from scene
            Players.Remove(player);
            await player.SetSceneAsync(null);

            // Remove player avatars
            SortedList<int, AvatarEntity> team = player.TeamManager.ActiveTeam;
            await RemoveEntitiesAsync(team.Values, VisionType.Remove);
            team.Clear();

            // Remove player gadgets
            foreach (ClientGadgetEntity gadget in player.GadgetManager.Gadgets)
            {
                await RemoveEntityAsync(gadget);
            }

            // Deregister scene if not in use
            if (Players.Count <= 0 && !dontDestroyWhenEmpty)
            {
                World.DeregisterScene(this);
            }
        }

        private async Task SetupPlayerAvatarsAsync(Player.Player player)
        {
            // Add new entities for player
            TeamInfo teamInfo = player.TeamManager.GetCurrentTeamInfo();
            foreach (int avatarId in teamInfo.AvatarInfo.Keys)
            {
                if (avatarId == 0) continue;
                AvatarEntity entity = new AvatarEntity(player.Scene, player.Avatars.GetAvatarById(avatarId));
                player.TeamManager.ActiveTeam = new SortedList<int, AvatarEntity>(teamInfo.AvatarInfo.Select(
                    w => new KeyValuePair<int, AvatarEntity>(w.Key, new AvatarEntity(player.Scene, w.Value))).ToDictionary(w => w.Key, w => w.Value));
            }
        }

        public async Task SpawnPlayerAsync(Player.Player player)
        {
            var teamManager = player.TeamManager;
            if (IsInScene(teamManager.GetCurrentAvatarEntity()))
            {
                return;
            }

            if (teamManager.GetCurrentAvatarEntity().FightProps[FightProperty.FIGHT_PROP_CUR_HP] <= 0f)
            {
                teamManager.GetCurrentAvatarEntity().FightProps[FightProperty.FIGHT_PROP_CUR_HP] = 1f;
            }

            await AddEntityAsync(teamManager.GetCurrentAvatarEntity());

            // Notify the client of any extra skill charges
            teamManager.ActiveTeam.AsParallel().ForAll(async x => await x.Value.Avatar.GetCurSkillDepot().SendAvatarSkillInfoNotify());
        }

        public async Task RespawnPlayerAsync(Player.Player player)
        {
            //player.StaminaManager.stopSustainedStaminaHandler(); // prevent drowning immediately after respawn

            // Revive all team members
            foreach (AvatarEntity entity in player.TeamManager.ActiveTeam.Values)
            {
                entity.FightProps[
                        FightProperty.FIGHT_PROP_CUR_HP] =
                    entity.FightProps[FightProperty.FIGHT_PROP_MAX_HP] * 0.4f;

                await player.SendPacketAsync(new PacketAvatarFightPropUpdateNotify(entity.Avatar, FightProperty.FIGHT_PROP_CUR_HP));
                await player.SendPacketAsync(new PacketAvatarLifeStateChangeNotify(entity.Avatar));
            }
            Vector3 respawnPos = GetRespawnPosition(player);

            // Teleport player and set player position
            await player.SendPacketAsync(new PacketPlayerEnterSceneNotify(player, EnterType.Self, EnterReason.Revival, player.Scene, respawnPos));
            player.Position = respawnPos;
        }
        public Vector3 GetRespawnPosition(Player.Player player)
        {
            Vector3 deathPos = player.Position;

            //TODO

            return deathPos;
        }

        private async Task AddEntityDirectly(GameEntity entity)
        {
            Entities.Add(entity.Id, entity);
            await entity.OnCreateAsync(); // Call entity create event
        }

        public async Task AddEntityAsync(GameEntity entity)
        {
            await AddEntityDirectly(entity);
            await BroadcastPacketAsync(new PacketSceneEntityAppearNotify(entity));
        }

        public async Task AddEntityToSingleClient(Player.Player player, GameEntity entity)
        {
            await AddEntityDirectly(entity);
            await player.SendPacketAsync(new PacketSceneEntityAppearNotify(entity));

        }

        public async Task AddEntities(IEnumerable<GameEntity> entities, VisionType visionType = VisionType.Born)
        {
            if (entities == null || !entities.Any())
            {
                return;
            }
            foreach (GameEntity entity in entities)
            {
                await AddEntityDirectly(entity);
            }

            await BroadcastPacketAsync(new PacketSceneEntityAppearNotify(entities, visionType));
        }

        public async Task<bool> RemoveEntityAsync(GameEntity entity, VisionType visionType = VisionType.Die)
        {
            if (Entities.Remove(entity.Id))
            {
                await BroadcastPacketAsync(new PacketSceneEntityDisappearNotify(entity, visionType));
                return true;
            }
            else return false;
        }
        public async Task RemoveEntitiesAsync(IEnumerable<GameEntity> entity, VisionType visionType)
        {
            var toRemove = entity.Where(w => Entities.Remove(w.Id));
            if (toRemove.Any())
            {
                await BroadcastPacketAsync(new PacketSceneEntityDisappearNotify(toRemove, visionType));
            }
        }
        public async Task ReplaceEntityAsync(AvatarEntity oldEntity, AvatarEntity newEntity)
        {
            Entities.Remove(oldEntity.Id);
            await AddEntityDirectly(newEntity);
            await BroadcastPacketAsync(new PacketSceneEntityDisappearNotify(oldEntity, VisionType.Replace));
            await BroadcastPacketAsync(new PacketSceneEntityAppearNotify(newEntity, VisionType.Replace, oldEntity.Id));
        }

        public async Task ShowOtherEntitiesAsync(Player.Player player)
        {
            List<GameEntity> entities = new();
            GameEntity currentEntity = player.TeamManager.GetCurrentAvatarEntity();

            foreach (GameEntity entity in Entities.Values)
            {
                if (entity == currentEntity)
                {
                    continue;
                }
                entities.Add(entity);
            }

            await player.SendPacketAsync(new PacketSceneEntityAppearNotify(entities, VisionType.Meet));
        }

        public async Task HandleAttackAsync(AttackResult result)
        {
            //TODO use AttackResult's data properly

            GameEntity target = GetEntityById(result.DefenseId);

            if (target == null)
            {
                return;
            }

            await target.DamageAsync(result.Damage, result.AttackerId);
        }

        public async Task KillEntityAsync(GameEntity target, uint attackerId = 0)
        {
            GameEntity? attacker = null;

            if (attackerId != 0)
            {
                attacker = GetEntityById(attackerId);
            }

            if (attacker != null)
            {
                // Check codex
                if (attacker is ClientGadgetEntity gadgetAttacker)
                {
                    var clientGadgetOwner = Entities[gadgetAttacker.OwnerEntityId];
                    if (clientGadgetOwner is AvatarEntity)
                    {
                        //((ClientGadgetEntity)attacker).Owner.Codex.CheckAnimal(target, CodexAnimalData.CodexAnimalUnlockCondition.CODEX_COUNT_TYPE_KILL);
                    }
                }
                else if (attacker is AvatarEntity avatarAttacker)
                {
                    //avatarAttacker.Avatar.Owner.Codex.CheckAnimal(target, CodexAnimalData.CodexAnimalUnlockCondition.CODEX_COUNT_TYPE_KILL);
                }
            }

            // Packet
            await BroadcastPacketAsync(new PacketLifeStateChangeNotify(target, LifeState.LIFE_DEAD, attackerId));

            // Remove entity from world
            await RemoveEntityAsync(target);

            // Death event
            await target.OnDeathAsync(attackerId);
        }

        public async Task OnTickAsync()
        {
            //TODO
        }

        public int GetEntityLevel(int baseLevel, int worldLevelOverride)
        {
            int level = worldLevelOverride > 0 ? worldLevelOverride + baseLevel - 22 : baseLevel;
            level = level >= 100 ? 100 : level;
            level = level <= 0 ? 1 : level;

            return level;
        }

        // Gadgets

        public async Task OnPlayerCreateGadget(ClientGadgetEntity gadget)
        {
            // Directly add
            AddEntityDirectly(gadget);

            // Add to owner's gadget list
            gadget.Owner.GadgetManager.Gadgets.Add(gadget);

            await BroadcastPacketToOthersAsync(gadget.Owner, new PacketSceneEntityAppearNotify(gadget));
        }

        public async Task OnPlayerDestroyGadget(uint entityId)
        {
            GameEntity entity = Entities[entityId];

            if (entity == null || !(entity is ClientGadgetEntity))
            {
                return;
            }

            // Get and remove entity
            ClientGadgetEntity gadget = (ClientGadgetEntity)entity;
            Entities.Remove(gadget.Id);

            // Remove from owner's gadget list
            gadget.Owner.GadgetManager.Gadgets.Remove(gadget);

            await BroadcastPacketToOthersAsync(gadget.Owner, new PacketSceneEntityDisappearNotify(gadget, VisionType.Die));
        }

        // Broadcasting
        public async Task BroadcastPacketAsync(BasePacket packet)
        {
            // Send to all players - might have to check if player has been sent data packets
            var tasks = new List<Task>();
            foreach (Player.Player player in Players)
            {
                tasks.Add(player.SendPacketAsync(packet));
            }
            await Task.WhenAll(tasks);
        }

        public async Task BroadcastPacketToOthersAsync(Player.Player excludedPlayer, BasePacket packet)
        {
            // Send to all players - might have to check if player has been sent data packets
            foreach (Player.Player player in Players)
            {
                if (player == excludedPlayer)
                {
                    continue;
                }
                // Send
                await player.SendPacketAsync(packet);
            }
        }

        public async Task AddItemEntity(int itemId, int amount, GameEntity bornForm)
        {
            if (!GameData.ItemDataMap.TryGetValue(itemId, out ItemData itemData))
            {
                return;
            }
            if (itemData.itemType == ItemType.ITEM_RELIQUARY || itemData.itemType == ItemType.ITEM_WEAPON)
            {
                float range = (1.5f + (.05f * amount));
                for (int i = 0; i < amount; i++)
                {
                    Vector3 pos = bornForm.Position;
                    ItemEntity entity = new ItemEntity(this, null, itemData, pos, 1);
                    await AddEntityAsync(entity);
                }
            }
            else
            {
                ItemEntity entity = new ItemEntity(this, null, itemData, bornForm.Position, amount);
                await AddEntityAsync(entity);
            }
        }
    }
}
