using Vim.Math3d;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal abstract class GameEntity
    {
        public uint Id { get; protected set; }
        public readonly Scene? Scene;

        public Vector3 Position { get; protected set; }
        public Vector3 Rotation { get; protected set; }

        public LifeState LiveState { get; protected set; }
        public MotionState MotionState { get; protected set; }
        public Dictionary<FightProperty, float> FightProps { get; protected set; }
        public uint LastMoveSceneTimeMs;
        public uint LastMoveReliableSeq;

        public bool LockHP;

        // Abilities
        public Dictionary<string, float> MetaOverrideMap { get; protected set; }
        public Dictionary<int, string> MetaModifiers { get; protected set; }

        public GameEntity(Scene? scene)
        {
            Scene = scene;
            MotionState = MotionState.None;
        }

        public uint GetEntityType()
        {
            return Id >> 24;
        }

        public World? GetWorld()
        {
            if (Scene == null) return null;
            else return Scene.World;
        }

        public virtual bool SetMotionState(MotionState state)
        {
            return false;
        }
        protected MotionInfo GetMotionInfo()
        {
            MotionInfo proto = new()
            {
                Pos = new Vector() { X = Position.X, Y = Position.Y, Z = Position.Z },
                Rot = new Vector() { X = Rotation.X, Y = Rotation.Y, Z = Rotation.Z },
                State = MotionState
            };

            return proto;
        }

        public virtual async Task<float> HealAsync(float amount)
        {
            float curHp = FightProps[FightProperty.FIGHT_PROP_CUR_HP];
            float maxHp = FightProps[FightProperty.FIGHT_PROP_MAX_HP];

            if (curHp >= maxHp)
            {
                return 0f;
            }

            float healed = Math.Min(maxHp - curHp, amount);
            FightProps[FightProperty.FIGHT_PROP_CUR_HP] += healed;
            await Scene.BroadcastPacketAsync(new PacketEntityFightPropUpdateNotify(this, FightProperty.FIGHT_PROP_CUR_HP));

            return healed;
        }

        public virtual async Task DamageAsync(float amount, uint attackerId = 0)
        {
            // Check if the entity has properties.
            if (!FightProps.ContainsKey(FightProperty.FIGHT_PROP_CUR_HP)) return;

            float curHp = FightProps[FightProperty.FIGHT_PROP_CUR_HP];
            if (!float.IsPositiveInfinity(curHp) || curHp <= amount)
            {
                // Add negative HP to the current HP property.
                FightProps[FightProperty.FIGHT_PROP_CUR_HP] -= amount;
            }

            // Check if dead
            bool isDead = false;
            if (FightProps[FightProperty.FIGHT_PROP_CUR_HP] <= 0f)
            {
                FightProps[FightProperty.FIGHT_PROP_CUR_HP] = 0f;
                isDead = true;
            }

            // Packets
            await Scene.BroadcastPacketAsync(new PacketEntityFightPropUpdateNotify(this, FightProperty.FIGHT_PROP_CUR_HP));

            // Check if dead.
            if (isDead)
                await Scene.KillEntityAsync(this, attackerId);
        }

        /**
        * Move this entity to a new position.
        * @param position The new position.
        * @param rotation The new rotation.
        */
        public async Task MoveAsync(Vector3 position, Vector3 rotation)
        {
            // Set the position and rotation.
            Position = position;
            Rotation = rotation;
        }

        /**
         * Called when a player interacts with this entity
         * @param player Player that is interacting with this entity
         * @param interactReq Interact request protobuf data
         */
        public virtual async Task OnInteractAsync(Player.Player player, GadgetInteractReq interactReq)
        {

        }


        /**
         * Called when this entity is added to the world
         */
        public virtual async Task OnCreateAsync()
        {

        }


        /**
         * Called when this entity dies
         * @param killerId Entity id of the entity that killed this entity
         */
        public virtual async Task OnDeathAsync(uint killerId)
        {

        }


        public abstract SceneEntityInfo ToProto();

    }
}
