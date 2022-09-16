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
    }
}
