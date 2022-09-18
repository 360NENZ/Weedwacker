using System.Linq;
using System.Reflection;


namespace Weedwacker.Shared.Enums
{

    public static class EnumHelper
    {
        public static T Get<T>(Enum enumValue) where T : Attribute
        {
            return enumValue.GetType().GetMember(enumValue.ToString()).First().GetCustomAttribute<T>();
        }
    }
}
