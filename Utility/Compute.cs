using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public static class Compute
    {
        public static int GetPercentage(int number, int maximum)
        {
            return (number * maximum) / 100;
        }

        public static double GetPercentage(double number, double maximum)
        {
            return (number * maximum) / 100;
        }
    }
}