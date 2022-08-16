using System;
using System.Globalization;

namespace BN.Infrastrure.Query
{
    public static class Convertors
    {
        public static string Toshamsi(this DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();
            return string.Format(@"{0}/{1}/{2}",
                pc.GetYear(date),
                pc.GetMonth(date),
                pc.GetDayOfMonth(date)
                );
        }
       
    }
}
