using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qt
{
    public static class ExtensionString
    {
        /// <summary>
        /// 串联
        /// </summary>
        /// <param name="str"></param>
        /// <param name="seperator"></param>
        /// <param name="alternation"></param>
        /// <param name="forceEndSeperator"></param>
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
    }
}
