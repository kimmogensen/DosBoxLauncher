namespace DosBoxLauncher.Functions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class TimeStamp
    {
        /// <summary>
        /// Gets the time stamp.
        /// YYYYMMDD-HHMMSS
        /// </summary>
        /// <returns>time stamp.YYYYMMDD-HHMMSS</returns>
        public static string GetTimeDateStamp()
        {
            DateTime dt = DateTime.Now;

            return GetTimeDateStamp(dt);
        }

        /// <summary>
        /// from the DateTime Class extract the
        /// 'YYYYMMDD_HHMMSS' format
        /// </summary>
        /// <param name="dt">The dt.</param>
        /// <returns>
        /// returns string in format <![CDATA[yyyymmdd_hhmmss]]>
        /// </returns>
        public static string GetTimeDateStamp(DateTime dt)
        {
            string date;
            string time;

            date = dt.Year.ToString() +
                    TrimDateProperties(dt.Month.ToString()) +
                    TrimDateProperties(dt.Day.ToString());
            time = TrimDateProperties(dt.Hour.ToString()) +
                    TrimDateProperties(dt.Minute.ToString()) +
                    TrimDateProperties(dt.Second.ToString());
            return date + "_" + time;
        }

        public static string GetTimeStamp()
        {
            DateTime dt = DateTime.Now;

            return GetTimeStamp(dt);
        }

        public static string GetTimeStamp(DateTime dt)
        {
            string time;
            time = string.Format(
                            "{0}:{1}:{2}",
                            TrimDateProperties(dt.Hour.ToString()),
                            TrimDateProperties(dt.Minute.ToString()),
                            TrimDateProperties(dt.Second.ToString()));
            return time;
        }

        /// <summary>
        /// Used by GetTimeStamp()
        /// </summary>
        /// <param name="property">DateTime instance Month or Day or Hour etc</param>
        /// <returns>
        /// A string added '0' in the start if number -lt 10
        /// </returns>
        private static string TrimDateProperties(string property)
        {
            int tester = int.Parse(property);
            if (tester < 10)
            {
                property = "0" + property;
            }

            return property;
        }
    }
}
