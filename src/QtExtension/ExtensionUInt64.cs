using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Qt
{
    public static class ExtensionUInt64
    {
        public static string ToHex(this UInt64 i)
        {
            return To(i, 16);
        }

        public static string ToOct(this UInt64 i)
        {
            return To(i, 8);
        }

        public static string ToBin(this UInt64 i)
        {
            return To(i, 2);
        }

        private static string To(UInt64 i, int @base)
        {
            unchecked
            {
                Int64 t = (Int64)i;
                return Convert.ToString(t, @base);
            }
        }

        /// <summary>
        /// 根据字节序取字节数组
        /// </summary>
        /// <param name="i"></param>
        /// <param name="littleEndian"></param>
        /// <returns></returns>
        public static byte[] GetBytes(this UInt64 i, bool littleEndian = true)
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
