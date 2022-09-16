using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer
{
    internal static class Extensions
    {
        public static int GetNextAvailableIndex<T>(this SortedList<int, T> sortedList)
        {
            int key = 1;
            int count = sortedList.Count;
            int counter = 0;
            do
            {
                if (count == 0) break;
                int nextKeyInList = sortedList.Keys[counter++];
                if (key != nextKeyInList) break;
                key = nextKeyInList + 1;
            } while (count != 1 && counter != count && key == sortedList.Keys[counter]);
            return key;
        }
        public static int AddNext<T>(this SortedList<int, T> sortedList, T item)
        {
            int key = sortedList.GetNextAvailableIndex();
            sortedList.Add(key, item);
            return key;
        }
        public static void WriteHandshake(this BinaryWriter bw, int convId)
        {
            bw.Write((byte)0x0);
            bw.Write((byte)0x0);
            bw.Write((byte)0x1);
            bw.Write((byte)0x45);
            bw.Write((byte)0x0);
            bw.Write(convId); // missing 3 bytes yet
            bw.Write((byte)0x49);
            bw.Write((byte)0x96);
            bw.Write((byte)0x02);
            bw.Write((byte)0xd2);
            bw.Write((byte)0x14);
            bw.Write((byte)0x51);
            bw.Write((byte)0x45);
            bw.Write((byte)0x45);
        }
    }
}
