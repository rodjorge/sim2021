using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace Simulacion_tp3
{
    abstract public class Distribucion
    {
        abstract public double calcularPe(double limInfIntervalo, double limSupIntervalo);
        public double calcularFe(double limInfIntervalo, double limSupIntervalo, int tamanioMuestra)
        {
            return this.calcularPe(limInfIntervalo, limSupIntervalo) * tamanioMuestra;
        }
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
