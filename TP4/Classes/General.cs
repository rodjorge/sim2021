using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static bool ValidarConversionDouble(string value)
        {
            try
            {
                double test = Double.Parse(value);
                return true;
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (FormatException e)
            {
                MessageBox.Show("Error de forma, ingrese un valor valido, ingresado: " + value);
            }
            return false;
        }

        public static bool ValidarConversionInt(string value)
        {
            try
            {
                double test = Int32.Parse(value);
                return true;
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (FormatException e)
            {
                MessageBox.Show("Error de forma, ingrese un valor valido, ingresado: " + value);
            }
            return false;
        }
    }
}
