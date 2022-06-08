using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delmain_C969
{
    class DateTimeHandler
    {
        public static string timestamp()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        /*** Converts UTC time to Local time ***/
        public static string toLocalTime(string dateTime)
        {
            DateTime utcTime = DateTime.Parse(dateTime.ToString()); 
            TimeZoneInfo systemTimeZone = TimeZoneInfo.Local;
            DateTime localDateTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, systemTimeZone);

            return localDateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }

        /*** Converts Local time to UTC ***/
        public static string toUTCTime(string dateTime)
        {
            DateTime localTime = DateTime.Parse(dateTime.ToString());
            DateTime utcTime = localTime.ToUniversalTime();

            return utcTime.ToString("yyyy-MM-dd HH:mm:ss");
        }

    }
}
