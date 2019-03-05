using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Qt
{
    public static class ExtensionString
    {
        /// <summary>
        /// 串联
        /// </summary>
        /// <param name="str"></param>
        /// <param name="seperator">分隔符</param>
        /// <param name="alternation">每隔多少字符插入分隔符</param>
        /// <param name="forceEndSeperator">是否强制在结尾插入分隔符</param>
        /// <returns></returns>
        public static string Joins(this string str, string seperator, int alternation = 1, bool forceEndSeperator = false)
        {
            if (alternation < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(alternation));
            }

            StringBuilder stringBuilder = new StringBuilder(str);
            List<int> idxList = new List<int>();
            for (int i = 0, count = str.Length; i < count; i += alternation)
            {
                idxList.Add(i);
            }
            for (int i = idxList.Count - 1; i >= 1; --i)
            {
                stringBuilder.Insert(idxList[i], seperator);
            }

            if (forceEndSeperator)
            {
                stringBuilder.Append(seperator);
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        /// UTF8编码取信息摘要MD5
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string MD5(this string str)
        {
            return MD5(str, Encoding.UTF8);
        }

        /// <summary>
        /// 根据指定编码取信息摘要MD5
        /// </summary>
        /// <param name="str"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string MD5(this string str, Encoding encoding)
        {
            byte[] sor = encoding.GetBytes(str);
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] result = md5.ComputeHash(sor);
            StringBuilder stringBuilder = new StringBuilder(40);
            for (int i = 0; i < result.Length; i++)
            {
                stringBuilder.Append(result[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        /// 是否正则匹配
        /// </summary>
        /// <param name="str"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static bool IsMatch(this string str, string pattern)
        {
            Regex regex = new Regex(pattern);
            return regex.IsMatch(str);
        }

        /// <summary>
        /// 正则匹配
        /// </summary>
        /// <param name="str"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static string Match(this string str, string pattern)
        {
            Regex regex = new Regex(pattern);
            return regex.Match(str).Value;
        }

        /// <summary>
        /// 正则匹配
        /// </summary>
        /// <param name="str"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static string[] Matches(this string str, string pattern)
        {
            Regex regex = new Regex(pattern);
            List<string> result = new List<string>();
            MatchCollection matchCollection = regex.Matches(str);
            for (int i = 0, count = matchCollection.Count; i < count; ++i)
            {
                result.Add(matchCollection[i].Value);
            }
            return result.ToArray();
        }

        public static Byte HexToUInt8(this string str)
        {
            return Convert.ToByte(str, 16);
        }

        public static Int16 HexToInt16(this string str)
        {
            return Convert.ToInt16(str, 16);
        }

        public static Int32 HexToInt32(this string str)
        {
            return Convert.ToInt32(str, 16);
        }

        public static Int64 HexToInt64(this string str)
        {
            return Convert.ToInt64(str, 16);
        }

        public static UInt16 HexToUInt16(this string str)
        {
            return Convert.ToUInt16(str, 16);
        }

        public static UInt32 HexToUInt32(this string str)
        {
            return Convert.ToUInt32(str, 16);
        }

        public static UInt64 HexToUInt64(this string str)
        {
            return Convert.ToUInt64(str, 16);
        }

        public static Byte OctToUInt8(this string str)
        {
            return Convert.ToByte(str, 8);
        }

        public static Int16 OctToInt16(this string str)
        {
            return Convert.ToInt16(str, 8);
        }

        public static Int32 OctToInt32(this string str)
        {
            return Convert.ToInt32(str, 8);
        }

        public static Int64 OctToInt64(this string str)
        {
            return Convert.ToInt64(str, 8);
        }

        public static UInt16 OctToUInt16(this string str)
        {
            return Convert.ToUInt16(str, 8);
        }

        public static UInt32 OctToUInt32(this string str)
        {
            return Convert.ToUInt32(str, 8);
        }

        public static UInt64 OctToUInt64(this string str)
        {
            return Convert.ToUInt64(str, 8);
        }

        public static Byte BinToUInt8(this string str)
        {
            return Convert.ToByte(str, 2);
        }

        public static Int16 BinToInt16(this string str)
        {
            return Convert.ToInt16(str, 2);
        }

        public static Int32 BinToInt32(this string str)
        {
            return Convert.ToInt32(str, 2);
        }

        public static Int64 BinToInt64(this string str)
        {
            return Convert.ToInt64(str, 2);
        }

        public static UInt16 BinToUInt16(this string str)
        {
            return Convert.ToUInt16(str, 2);
        }

        public static UInt32 BinToUInt32(this string str)
        {
            return Convert.ToUInt32(str, 2);
        }

        public static UInt64 BinToUInt64(this string str)
        {
            return Convert.ToUInt64(str, 2);
        }
    }
}
