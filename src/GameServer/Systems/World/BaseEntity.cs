using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Systems.Ability;

namespace Weedwacker.GameServer.Systems.World
{
    internal abstract class BaseEntity
    {
        [BsonIgnore] public uint EntityId { get; set; }
        [BsonIgnore] public BaseAbilityManager AbilityManager { get; protected set; }
        public uint GetEntityType()
        {
            return EntityId >> 24;
        }
    }
}
