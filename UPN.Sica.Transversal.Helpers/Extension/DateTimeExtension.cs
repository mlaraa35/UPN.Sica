using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Extension
{
    public static class DateTimeExtension
    {
        public static string ToShortString(this DateTime me)
        {
            return me.ToString("dd/MM/yyyy");
        }

        public static string ToLongString(this DateTime me)
        {
            return me.ToString("dd/MM/yyyy HH:mm:ss");
        }

        public static string ToLongDate(this DateTime me)
        {
            return me.ToString("ddMMyyyy_HHmmss");
        }
    }
}
