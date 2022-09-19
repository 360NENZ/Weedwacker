using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weedwacker.GameServer
{
    internal static class Extensions
    {
        public static string JoinFormat<T>(this IEnumerable<T> list, string separator,
                                   string formatString)
        {
            formatString = string.IsNullOrWhiteSpace(formatString) ? "{0}" : formatString;
            return string.Join(separator,
                               list.Select(item => string.Format(formatString, item)));
        }
        public static void WriteConvID(this BinaryWriter bw, long convId)
        {
            //bw.Write(convId);
            bw.Write((int)(convId >> 32));
            bw.Write((int)(convId & 0xFFFFFFFF));
        }
        public static long GetNextAvailableIndex<T>(this SortedList<long, T> sortedList)
        {
            long key = 1;
            long count = sortedList.Count;
            long counter = 0;
            do
            {
                if (count == 0) break;
                long nextKeyInList = sortedList.Keys.ElementAt((Index)(counter++));
                if (key != nextKeyInList) break;
                key = nextKeyInList + 1;
            } while (count != 1 && counter != count && key == sortedList.Keys.ElementAt((Index)counter));
            return key;
        }
        public static long AddNext<T>(this SortedList<long, T> sortedList, T item)
        {
            long key = sortedList.GetNextAvailableIndex();
            sortedList.Add(key, item);
            return key;
        }
        public static int ReadInt32BE(this BinaryReader br) => BinaryPrimitives.ReadInt32BigEndian(br.ReadBytes(4));
        public static uint ReadUInt32BE(this BinaryReader br) => BinaryPrimitives.ReadUInt32BigEndian(br.ReadBytes(4));
        public static ushort ReadUInt16BE(this BinaryReader br) => BinaryPrimitives.ReadUInt16BigEndian(br.ReadBytes(2));
        public static void WriteUInt16BE(this BinaryWriter bw, ushort value)
        {
            var data = new byte[2];
            BinaryPrimitives.WriteUInt16BigEndian(data, value);
            bw.Write(data);
        }
        public static void WriteInt32BE(this BinaryWriter bw, int value)
        {
            var data = new byte[4];
            BinaryPrimitives.WriteInt32BigEndian(data, value);
            bw.Write(data);
        }
        public static void WriteUInt32BE(this BinaryWriter bw, uint value)
        {
            var data = new byte[4];
            BinaryPrimitives.WriteUInt32BigEndian(data, value);
            bw.Write(data);
        }
    }
}
