using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using MathNet.Numerics;

namespace Simulacion_tp3
{
    abstract public class Distribucion
    {
        abstract public double calcularPe(double limInfIntervalo, double limSupIntervalo);
        public double calcularFe(double limInfIntervalo, double limSupIntervalo, int tamanioMuestra)
        {
            return this.calcularPe(limInfIntervalo, limSupIntervalo) * tamanioMuestra;
        }

        public virtual bool esDiscreta() => false;
    }

    public class DistribucionUniforme : Distribucion
    {
        private double limiteSuperior;
        private double limiteInferior;

        public DistribucionUniforme(double limiteSuperior, double limiteInferior)
        {
            this.limiteSuperior = limiteSuperior;
            this.limiteInferior = limiteInferior;
        }
        override public double calcularPe(double limInfIntervalo, double limSupIntervalo)
        {
            return (limSupIntervalo - limInfIntervalo) / (this.limiteSuperior - this.limiteInferior);
        }
    }

    public class DistribucionExponencial : Distribucion
    {
        private double lambda;

        public DistribucionExponencial(double lambda)
        {
            this.lambda = lambda;
        }

        override public double calcularPe(double limInfIntervalo, double limSupIntervalo)
        {
            return Math.Exp(-this.lambda * limInfIntervalo) - Math.Exp(-this.lambda * limSupIntervalo);
        }
    }

    public class DistribucionPoisson : Distribucion
    {
        private double lambda;

        public DistribucionPoisson(double lambda)
        {
            this.lambda = lambda;
        }

        public override bool esDiscreta() => true;

        public override double calcularPe(double limInfIntervalo, double limSupIntervalo)
        {
            int limInfEntero = (int) Math.Ceiling(limInfIntervalo);
            int limSupEntero = (int) Math.Ceiling(limSupIntervalo);

            double peAcum = 0;
            double pe;
            for (int x = limInfEntero; x < limSupEntero; x++)
            {
                pe = Math.Pow(lambda, x) * Math.Exp(-lambda) / SpecialFunctions.Factorial(x);
                peAcum += pe;
            }

            return peAcum;
        }
    }

    public class DistribucionNormal : Distribucion
    {
        private double media;
        private double desviacion;
        private Chart chart;
        private StatisticFormula formulasEstadisticas;

        public DistribucionNormal(double media, double desviacion)
        {
            this.media = media;
            this.desviacion = desviacion;
            this.chart = new Chart();
            this.formulasEstadisticas = this.chart.DataManipulator.Statistics;
        }

        public override double calcularPe(double limInfIntervalo, double limSupIntervalo)
        {
            double limInfNormalizado = (limInfIntervalo - this.media) / this.desviacion;
            double limSupNormalizado = (limSupIntervalo - this.media) / this.desviacion;

            return this.formulasEstadisticas.NormalDistribution(limSupNormalizado) - this.formulasEstadisticas.NormalDistribution(limInfNormalizado);
        }
    }
}
