namespace Weedwacker.GameServer.Data
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class ResourceAttribute : Attribute
    {
        /** Names of the file that this Resource loads from */
        public readonly string Names;

        /** Load priority - dictates which order to load this resource, with "highest" being loaded first */
        public readonly LoadPriority Priority = LoadPriority.NORMAL;

        public ResourceAttribute(string names)
        {
            Names = names;
        }

        public ResourceAttribute(string names, LoadPriority priority)
        {
            Names = names;
            Priority = priority;
        }

        public enum LoadPriority
        {
            HIGHEST,
            HIGH,
            NORMAL,
            LOW,
            LOWEST

        }
    }
}
