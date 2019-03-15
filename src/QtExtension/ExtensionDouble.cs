using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qt
{
    public static class ExtensionDouble
    {
        /// <summary>
        /// 中国式四舍五入
        /// </summary>
        /// <param name="number"></param>
        /// <param name="decimals">需要保留的位数</param>
        /// <returns></returns>
        public static double Round(this double number, int decimals)
        {
            double t = Math.Round(number, decimals, MidpointRounding.AwayFromZero);
            string pattern = "#0." + new string('0', decimals);
            return double.Parse(t.ToString(pattern));
        }
    }
}
