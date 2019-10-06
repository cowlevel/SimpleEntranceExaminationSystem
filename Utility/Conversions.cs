using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public static class Conversions
    {

        public static string TimeMinuteToString(int totalMinutes)
        {
            int hour = totalMinutes / 60;
            int minute = totalMinutes % 60;
            string output;

            if (hour == 0)
            {
                output = string.Format("{0} minutes", minute);
                return output;
            }

            if (hour == 1)
            {
                if (minute == 0)
                {
                    output = string.Format("{0} hour", hour);
                }
                else if (minute == 1)
                {
                    output = string.Format("{0} hour && {1} minute", hour, minute);
                }
                else
                {
                    output = string.Format("{0} hour && {1} minutes", hour, minute);
                }
            }
            else
            {
                if (minute == 0)
                {
                    output = string.Format("{0} hours", hour);
                }
                else if (minute == 1)
                {
                    output = string.Format("{0} hours && {1} minute", hour, minute);
                }
                else
                {
                    output = string.Format("{0} hours && {1} minutes", hour, minute);
                }
            }

            return output;
        }
    }
}