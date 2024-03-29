﻿using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Systems.Player
{
    internal class ProgressManager
    {

        [BsonElement("_id")]
        [BsonId] public int OwnerId { get; private set; }
        private Player Owner;
        public Dictionary<OpenStateType, int> OpenStates = new(); // SET ONLY THROUGH THE OPENSTATEMANAGER
        public HashSet<int> UnlockedForgingBlueprints = new();
        public HashSet<int> UnlockedCombines = new();
        //public Dictionary<long, ExpeditionInfo> ExpeditionInfo;
        public Dictionary<int, int> UnlockedRecipies = new();
        //public List<ActiveForgeData> activeForges;
        [BsonElement] public Dictionary<int, int> QuestGlobalVariables = new();
        [BsonSerializer(typeof(IntDictionarySerializer<HashSet<int>>))]
        public Dictionary<int, HashSet<int>> UnlockedSceneAreas = new();
        [BsonSerializer(typeof(IntDictionarySerializer<HashSet<int>>))]
        public Dictionary<int, HashSet<int>> UnlockedScenePoints = new();

        public ProgressManager(Player owner)
        {
            Owner = owner;
            OwnerId = owner.GameUid;
        }

        public async Task OnPlayerCreate()
        {
            await Owner.OpenStateManager.OnPlayerCreate();
        }

        public async Task OnLoadAsync(Player owner)
        {
            Owner = owner;
        }
    }
}
