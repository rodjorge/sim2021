using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Classes
{
    static class General
    {
        public static double TruncateDecimal(double number, int precision)
        {
            number *= Math.Pow(10, precision);
            int temp = (int) number;

            return (double)temp / Math.Pow(10, precision);
        } 
    }
}
