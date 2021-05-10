using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Temporizadores.Helpers
{
    public static class DateTimeExtension
    {
        public static string HoursMinutesString(this DateTime date)
        {
            return date.Hour.ToString().PadLeft(2, '0') + ":" + date.Minute.ToString().PadLeft(2, '0');
        }
        public static int TotalMinutes(this DateTime date) => (date.Hour * 60) + date.Minute;
        public static bool IsValid(this DateTime date) => !Equals(date, default(DateTime));
    }
}
