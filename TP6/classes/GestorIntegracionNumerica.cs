using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.classes
{
    class GestorIntegracionNumerica
    {
        private double h;
        private int precisionDecimal;

        public GestorIntegracionNumerica(double h)
        {
            this.h = h;
            this.precisionDecimal = 0;
            while(h % 1 != 0)
            {
                this.precisionDecimal++;
                h *= 10;
            }
        }

        public double Integrar(int C, double dObjetivo) => this.Integrar(C, dObjetivo, out List<double?[]> proceso);

        public double Integrar(int C, double dObjetivo, out List<double?[]> proceso)
        {
            proceso = new List<double?[]>();
            proceso.Add(new double?[] { null, null, null, 0, 0 });
            int iterAnt = 0;
            double? t, D, DPrima, t_1, D_1;
            while(proceso[iterAnt][4] < dObjetivo)
            {
                // Iteracion de método de euler
                t = proceso[iterAnt][3];
                D = proceso[iterAnt][4];
                DPrima = 0.6 * C + t;   // DPrima = dD/dt = 0,6*C+t
                t_1 = Math.Round((double)t + this.h, this.precisionDecimal);
                D_1 = D + this.h * DPrima;

                proceso.Add(new double?[] { t, D, DPrima, t_1, D_1 });
                iterAnt++;
            }
            // Ultima fila, contiene los valores de D y t buscados
            t = proceso[iterAnt][3];
            D = proceso[iterAnt][4];
            proceso.Add(new double?[] { t, D, null, null, null });

            return (double) t;
        }
    }
}
