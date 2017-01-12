using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Extension
{
    public static class IntExtension
    {
        #region Nullable Int's...

        public static string PadLeft(this int? me, int totalWidth, char paddingChar)
        {
            return me.ToString().PadLeft(totalWidth, paddingChar);
        }

        public static string PadRight(this int? me, int totalWidth, char paddingChar)
        {
            return me.ToString().PadRight(totalWidth, paddingChar);
        }

        public static string PadLeftZero(this int? me, int totalWidth)
        {
            return me.PadLeft(totalWidth, '0');
        }

        public static string PadRightZero(this int? me, int totalWidth)
        {
            return me.PadRight(totalWidth, '0');
        } 
        #endregion

        #region Normal Int's...

        public static string PadLeft(this int me, int totalWidth, char paddingChar)
        {
            return me.ToString().PadLeft(totalWidth, paddingChar);
        }

        public static string PadRight(this int me, int totalWidth, char paddingChar)
        {
            return me.ToString().PadRight(totalWidth, paddingChar);
        }

        public static string PadLeftZero(this int me, int totalWidth)
        {
            return me.PadLeft(totalWidth, '0');
        }

        public static string PadRightZero(this int me, int totalWidth)
        {
            return me.PadRight(totalWidth, '0');
        } 
        #endregion

        #region Object to Int...

        //public static int ToInt(this object me)
        //{
        //    return Convert.ToInt32(me);
        //}

        #endregion
    }
}
