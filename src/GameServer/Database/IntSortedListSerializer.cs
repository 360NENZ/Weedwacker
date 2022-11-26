using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;

namespace Weedwacker.GameServer.Database
{
    internal class IntSortedListSerializer<V> : DictionarySerializerBase<SortedList<int, V>>
    {
        public IntSortedListSerializer() : base(MongoDB.Bson.Serialization.Options.DictionaryRepresentation.Document)
        {
        }

        protected override SortedList<int, V> CreateInstance()
        {
            return new SortedList<int, V>();
        }

        public override void Serialize(BsonSerializationContext context, BsonSerializationArgs args, SortedList<int, V> value)
        {
            if (value != null)
            {
                Dictionary<string, V> dic = value.ToDictionary(d => d.Key.ToString(), d => d.Value);
                BsonSerializer.Serialize<Dictionary<string, V>>(context.Writer, dic);
            }
            else
                BsonSerializer.Serialize<object>(context.Writer, null);
        }
        public override SortedList<int, V> Deserialize(BsonDeserializationContext context, BsonDeserializationArgs args)
        {
            Dictionary<string, V> dic = BsonSerializer.Deserialize<Dictionary<string, V>>(context.Reader);
            if (dic == null)
                return null;

            SortedList<int, V> ret = new SortedList<int, V>();
            foreach (var pair in dic)
            {
                int key;
                if (!int.TryParse(pair.Key, out key))
                    continue;
                ret[key] = pair.Value;
            }
            return ret;
        }
    }
}
