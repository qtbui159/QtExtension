using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qt
{
    public static class ExtensionUInt8
    {
        public static string ToHex(this byte i)
        {
            return To(i, 16);
        }

        public static string ToOct(this byte i)
        {
            return To(i, 8);
        }

        public static string ToBin(this byte i)
        {
            return To(i, 2);
        }

        public static string To(byte b,int @base)
        {
            return Convert.ToString(b, @base);
        }
    }
}
