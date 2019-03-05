using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qt
{
    public static class ExtensionDateTimeOffset
    {
        /// <summary>
        /// 是否是今天
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static bool IsToday(this DateTimeOffset dateTime)
        {
            return DateTimeOffset.Now.Date == dateTime.Date;
        }

        /// <summary>
        /// 获取一天的开始和结束
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTimeOffset[] GetDaySection(this DateTimeOffset dateTime)
        {
            DateTimeOffset start = dateTime.Date;
            DateTimeOffset end = dateTime.Date.AddDays(1).AddMilliseconds(-1);

            return new DateTimeOffset[] { start, end };
        }

        /// <summary>
        /// 获取一个月的开始和结束
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTimeOffset[] GetMonthSection(this DateTimeOffset dateTime)
        {
            DateTimeOffset start = new DateTime(dateTime.Year, dateTime.Month, 1, 0, 0, 0, 0);
            DateTimeOffset end = start.AddMonths(1).AddMilliseconds(-1);
            return new DateTimeOffset[] { start, end };
        }

        /// <summary>
        /// 获取一年的开始和结束
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTimeOffset[] GetYearSectin(this DateTimeOffset dateTime)
        {
            DateTimeOffset start = new DateTime(dateTime.Year, 1, 1, 0, 0, 0, 0);
            DateTimeOffset end = start.AddYears(1).AddMilliseconds(-1);
            return new DateTimeOffset[] { start, end };
        }
    }
}
