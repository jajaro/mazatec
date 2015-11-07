using System;
using System.Threading;

namespace Mazatec.Core.Date
{
    /// <summary>
    /// </summary>
    public static class DateTimeUtils
    {
        ///<summary>
        ///</summary>
        public static DateTime GetPreviousDate(DateTime date)
        {
            return date.Date - TimeSpan.FromDays(1);
        }

        ///<summary>
        ///</summary>
        public static DateTime GetNextDate(DateTime date)
        {
            return date.Date + TimeSpan.FromDays(1);
        }

        ///<summary>
        ///</summary>
        public static DateTime ToEndOfPreviousDate()
        {
            return ToEndOfPreviousDate(DateTime.Now);
        }

        ///<summary>
        ///</summary>
        public static DateTime ToEndOfPreviousDate(DateTime date)
        {
            return ToEndOfDate(date.Date - TimeSpan.FromHours(1));
        }

        ///<summary>
        ///</summary>
        public static DateTime? ToEndOfPreviousDate(DateTime? date)
        {
            if (date.HasValue)
            {
                return ToEndOfPreviousDate(date.Value);
            }
            return date;
        }

        ///<summary>
        ///</summary>
        public static DateTime ToEndOfDate(DateTime date)
        {
            return date.Date + TimeSpan.FromSeconds(86400 - 1);
        }

        ///<summary>
        ///</summary>
        public static DateTime? ToEndOfDate(DateTime? date)
        {
            if (date.HasValue)
            {
                return ToEndOfDate(date.Value);
            }
            return date;
        }

        ///<summary>
        ///</summary>
        public static DateTime ToStartOfNextDate(DateTime date)
        {
            return ToStartOfDate(date + TimeSpan.FromDays(1));
        }

        ///<summary>
        ///</summary>
        public static DateTime? ToStartOfNextDate(DateTime? date)
        {
            if (date.HasValue)
            {
                return ToStartOfNextDate(date.Value);
            }
            return date;
        }

        ///<summary>
        ///</summary>
        public static DateTime ToStartOfDate(DateTime date)
        {
            return date.Date;
        }

        ///<summary>
        ///</summary>
        public static DateTime? ToStartOfDate(DateTime? date)
        {
            if (date.HasValue)
            {
                return ToStartOfDate(date.Value);
            }
            return date;
        }

        ///<summary>
        ///</summary>
        ///<param name="dt"></param>
        ///<returns></returns>
        public static string ToDateTimeString(DateTime dt)
        {
            return String.Format("{0} {1}", dt.ToShortDateString(), dt.ToShortTimeString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string ToShortDateString(DateTime? dt)
        {
            if (dt.HasValue) return dt.Value.ToShortDateString();
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dtSorce"></param>
        /// <param name="dtNeighbour"></param>
        /// <param name="sec"></param>
        /// <returns></returns>
        public static bool IsNeighbourhood(DateTime dtSorce, DateTime dtNeighbour, double sec)
        {
            return dtSorce >= dtNeighbour - TimeSpan.FromSeconds(sec) &&
                   dtSorce <= dtNeighbour + TimeSpan.FromSeconds(sec);
        }

        ///<summary>
        ///</summary>
        public static readonly DateTime MinStartDate = new DateTime(1800, 1, 1);

        /// <summary>
        /// </summary>
        public static readonly TimeSpan InfiniteTimeSpan = TimeSpan.FromMilliseconds(Timeout.Infinite);
    }
}
