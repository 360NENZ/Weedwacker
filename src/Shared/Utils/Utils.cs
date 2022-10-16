namespace Weedwacker.Shared.Utils
{
    public static class Utils
    {
        public static ulong AbilityHash(string str)
        {
            ulong hash = 0;
            char[] asCharArray = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                hash = ((asCharArray[i] + 131 * hash) & 0xFFFFFFFF) >> 0;
            }
            return hash;
        }
    }

}