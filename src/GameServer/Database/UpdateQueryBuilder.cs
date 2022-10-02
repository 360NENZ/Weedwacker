using MongoDB.Bson;
using System.Linq.Expressions;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System.Text.RegularExpressions;
using System.Text;

namespace Weedwacker.GameServer.Database
{


    class UpdateQueryBuilder<T>
    {
        /// <summary>
        ///     _id of document to update. 
        /// </summary>
        private string? Filter;

        /// <summary>
        ///     Example:
        ///     FirstName, Antonio
        ///     Education.Elementary.Year, 2004
        /// </summary>
        private List<KeyValuePair<string, object>> ValuesToSet { get; set; } = new List<KeyValuePair<string, object>>();
        private List<KeyValuePair<string, object>> ValuesToUnSet { get; set; } = new();
        private List<KeyValuePair<string, object>> ValuesToInc { get; set; } = new();

        public void SetFilter(Expression<Func<T, bool>> filterDefinition)
        {
            var documentSerializer = BsonSerializer.SerializerRegistry.GetSerializer<T>();
            var where = Builders<T>.Filter.Where(filterDefinition).Render(documentSerializer, BsonSerializer.SerializerRegistry);
            Filter = where.ToJson();
        }

        public void AddValueToSet(string name, object value)
        {
            ValuesToSet.Add(new KeyValuePair<string, object>(name, value));
        }
        public void AddValueToSet(Expression<Func<T, object>> name, object value)
        {
            string result = EvaluateNameExpression(name);
            AddValueToSet(result, value);
        }
        public void AddValueToUnSet(string name, object value)
        {
            ValuesToUnSet.Add(new KeyValuePair<string, object>(name, value));
        }
        public void AddValueToUnSet(Expression<Func<T, object>> name, object value)
        {
            string result = EvaluateNameExpression(name);
            AddValueToUnSet(result, value);
        }
        public void AddValueToInc(string name, object value)
        {
            ValuesToInc.Add(new KeyValuePair<string, object>(name, value));
        }
        public void AddValueToInc(Expression<Func<T, object>> name, object value)
        {
            string result = EvaluateNameExpression(name);
            ValuesToInc.Add(new KeyValuePair<string, object>(result, value));
        }

        private string EvaluateNameExpression(Expression<Func<T, object>> name)
        {
            var memberExpression = name.Body as MemberExpression;
            if (memberExpression == null)
            {
                if (name.Body is UnaryExpression unaryExpression && unaryExpression.NodeType == ExpressionType.Convert)
                    memberExpression = unaryExpression.Operand as MemberExpression;
            }

            var result = memberExpression.ToString();
            result = result.Substring(result.IndexOf('.') + 1);

            if (result.Contains("get_Item"))
                result = Regex.Replace(result, @"(?x) get_Item \( (\d+) \)", m => $"{m.Groups[1].Value}");
            return result;
        }

        public Tuple<string?,string> Build()
        {
            if (ValuesToSet.Any() == false || ValuesToUnSet.Any() == false || ValuesToInc.Any() == false)
            {
                // nothing to update
                return null;
            }

            /*
            update({ 
            _id: 7, 
            "comments._id": ObjectId("4da4e7d1590295d4eb81c0c7")
            },{
            $set: {"comments.$.type": abc}
            }, false, true
            );
            */

            StringBuilder sb = new StringBuilder();

            sb.Append("{");
            {
                if (ValuesToSet.Any() == true)
                {
                    sb.Append("$set:{");
                    foreach (var item in ValuesToSet)
                    {
                        sb.Append('"');
                        sb.Append(item.Key);
                        sb.Append('"');
                        sb.Append(':');

                        var value = BsonExtensionMethods.ToJson(item.Value);
                        sb.Append(value);
                        sb.Append(',');
                    }
                    // remove last comma
                    sb.Length--;
                    sb.Append('}');
                }
                if (ValuesToUnSet.Any() == true)
                {
                    sb.Append("$unset:{");
                    foreach (var item in ValuesToSet)
                    {
                        sb.Append('"');
                        sb.Append(item.Key);
                        sb.Append('"');
                        sb.Append(':');

                        var value = BsonExtensionMethods.ToJson(item.Value);
                        sb.Append(value);
                        sb.Append(',');
                    }
                    // remove last comma
                    sb.Length--;
                    sb.Append('}');
                }
                if (ValuesToInc.Any() == true)
                {
                    sb.Append("$inc:{");
                    foreach (var item in ValuesToSet)
                    {
                        sb.Append('"');
                        sb.Append(item.Key);
                        sb.Append('"');
                        sb.Append(':');

                        var value = BsonExtensionMethods.ToJson(item.Value);
                        sb.Append(value);
                        sb.Append(',');
                    }
                    // remove last comma
                    sb.Length--;
                    sb.Append('}');
                }
            }
            sb.Append("}");

            return new Tuple<string?,string>(Filter,sb.ToString());




        }
    }
}
