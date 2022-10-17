using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;

namespace Weedwacker.GameServer.Database
{
    public class LongDictionarySerializer<K> : DictionarySerializerBase<Dictionary<long, K>>
    {
        public LongDictionarySerializer() : base(MongoDB.Bson.Serialization.Options.DictionaryRepresentation.Document)
        {
        }

        protected override Dictionary<long, K> CreateInstance()
        {
            return new Dictionary<long, K>();
        }

        public override void Serialize(BsonSerializationContext context, BsonSerializationArgs args, Dictionary<long, K> value)
        {
            if (value != null)
            {
                Dictionary<string, K> dic = value.ToDictionary(d => d.Key.ToString(), d => d.Value);
                BsonSerializer.Serialize<Dictionary<string, K>>(context.Writer, dic);
            }
            else
                BsonSerializer.Serialize<object>(context.Writer, null);
        }
        public override Dictionary<long, K> Deserialize(BsonDeserializationContext context, BsonDeserializationArgs args)
        {
            Dictionary<string, K> dic = BsonSerializer.Deserialize<Dictionary<string, K>>(context.Reader);
            if (dic == null)
                return null;

            Dictionary<long, K> ret = new Dictionary<long, K>();
            foreach (var pair in dic)
            {
                long key;
                if (!long.TryParse(pair.Key, out key))
                    continue;
                ret[key] = pair.Value;
            }
            return ret;
        }
    }
}
