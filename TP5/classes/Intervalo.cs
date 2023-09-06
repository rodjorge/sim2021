using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_tp3
{
    class Intervalo
    {
        private Distribucion distribucion;
        private double limSup;
        private double limInf;
        private double fo;

        public Intervalo(double limInf, double limSup, Distribucion distribucion)
        {
            this.distribucion = distribucion;
            this.limSup = limSup;
            this.limInf = limInf;
            this.fo = 0;
        }

        public double Fo { get => fo; set => fo = value; }
        public double LimSup { get => limSup; set => limSup = value; }
        public double LimInf { get => limInf; set => limInf = value; }

        public double calcularFe(int tamanioMuestra)
        {
            return Math.Round(distribucion.calcularFe(this.limInf, this.limSup, tamanioMuestra), 4);
        }

        public double calcularC(int tamanioMuestra)
        {
            double fe = this.calcularFe(tamanioMuestra);
            return Math.Round(Math.Pow(this.fo - fe, 2) / fe, 4);
        }
    }
}
