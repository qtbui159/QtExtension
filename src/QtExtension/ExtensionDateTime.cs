using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qt
{
    public static class ExtensionDateTime
    {
        /// <summary>
        /// 是否是今天
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static bool IsToday(this DateTime dateTime)
        {
            return DateTime.Today.Date == dateTime.Date;
        }

        /// <summary>
        /// 获取一天的开始和结束
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime[] GetDaySection(this DateTime dateTime)
        {
            DateTime start = dateTime.Date;
            DateTime end = dateTime.Date.AddDays(1).AddMilliseconds(-1);

            return new DateTime[] { start, end };
        }

        /// <summary>
        /// 获取一个月的开始和结束
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime[] GetMonthSection(this DateTime dateTime)
        {
            DateTime start = new DateTime(dateTime.Year, dateTime.Month, 1, 0, 0, 0, 0);
            DateTime end = start.AddMonths(1).AddMilliseconds(-1);
            return new DateTime[] { start, end };
        }

        /// <summary>
        /// 获取一年的开始和结束
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime[] GetYearSectin(this DateTime dateTime)
        {
            DateTime start = new DateTime(dateTime.Year, 1, 1, 0, 0, 0, 0);
            DateTime end = start.AddYears(1).AddMilliseconds(-1);
            return new DateTime[] { start, end };
        }
    }
}
