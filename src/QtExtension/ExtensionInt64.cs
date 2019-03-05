using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qt
{
    public static class ExtensionInt64
    {
        public static string ToHex(this Int64 i)
        {
            return To(i, 16);
        }

        public static string ToOct(this Int64 i)
        {
            return To(i, 8);
        }

        public static string ToBin(this Int64 i)
        {
            return To(i, 2);
        }

        private static string To(Int64 i, int @base)
        {
            return Convert.ToString(i, @base);
        }

        /// <summary>
        /// 根据字节序取字节数组
        /// </summary>
        /// <param name="i"></param>
        /// <param name="littleEndian"></param>
        /// <returns></returns>
        public static byte[] GetBytes(this Int64 i, bool littleEndian = true)
        {
            byte[] result = BitConverter.GetBytes(i);
            if (littleEndian)
            {
                return result;
            }
            return result.Reverse().ToArray();
        }
    }
}
