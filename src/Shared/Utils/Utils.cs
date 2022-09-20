namespace Weedwacker.Shared.Utils
{
    public static class Utils
    {
        public static int AbilityHash(string str)
        {
            int v7 = 0;
            int v8 = 0;
            char[] toChar = str.ToCharArray();
            while (v8 < str.Length)
            {
                v7 = toChar[v8++] + 131 * v7;
            }
            return v7;
        }
    }

}