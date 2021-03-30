using System;
using System.Collections.Generic;
using System.Text;

namespace Simulacion_tp3
{
    class GeneradorVariables
    {
        private Random generadorRandom;
        private int semilla;

        public int Semilla { get => semilla; set => semilla = value; }

        public GeneradorVariables(int semilla)
        {
            this.generadorRandom = new Random(semilla);
            this.semilla = semilla;
        }

        public GeneradorVariables()
        {
            this.generadorRandom = new Random();
        }

        private double truncarA4Decimales(double num)
        {
            return Math.Floor(num * 10000) / 10000;
        }

        public double generarVariableUniforme(double limInf, double limSup)
        {
            //Metodo de transformada inversa
            //Genera una variable aleatoria que se corresponde con una distribución uniforme continua de A a B
            //x = A + RND (B - A)
            double nroRandom = this.generadorRandom.NextDouble();
            return this.truncarA4Decimales(limInf + nroRandom * (limSup - limInf));
        }

        public double generarVariableExponencialConLambda(double lambda)
        {
            //Metodo de tranformada inversa
            //Genera una variable aleatoria que se corresponde con una distribucion exponencial negativa con cierto lambda
            //x = -1/λ * Ln(1 - RND)
            double nroRandom = this.generadorRandom.NextDouble();
            return this.truncarA4Decimales((double) -1 / lambda * Math.Log(1 - nroRandom));
        }

        public double generarVariableExponencialConMedia(double media)
        {
            //Metodo de tranformada inversa
            //Genera una variable aleatoria que se corresponde con una distribucion exponencial negativa con cierto lambda
            //x = -1/λ * Ln(1 - RND)
            double lambda = 1 / media;
            double nroRandom = this.generadorRandom.NextDouble();
            return this.truncarA4Decimales((double) -1 / lambda * Math.Log(1 - nroRandom));
        }

        public List<double> generarVariableNormal(double media, double desviacion)
        {
            //Metodo de Box-Muller
            //Genera 2 variables aleatorias que se corresponden con una distribucion normal con cierta media y distribucion
            //x1 = [√{-2 * Ln(RND1)} * cos(2π * RND2)] * σ + µ
            //x2 = [√{-2 * Ln(RND1)} * sen(2π * RND2)] * σ + µ
            double nroRandom1 = this.generadorRandom.NextDouble();
            double nroRandom2 = this.generadorRandom.NextDouble();
            List<double> variablesGeneradas = new List<double>();

            variablesGeneradas.Add(this.truncarA4Decimales((Math.Sqrt(-2 * Math.Log(nroRandom1)) * Math.Cos(2 * Math.PI * nroRandom2)) * desviacion + media));
            variablesGeneradas.Add(this.truncarA4Decimales((Math.Sqrt(-2 * Math.Log(nroRandom1)) * Math.Sin(2 * Math.PI * nroRandom2)) * desviacion + media));

            return variablesGeneradas;
        }

        public List<double> generarListaVariablesUniformes(double limInf, double limSup, int tamanio)
        {
            List<double> variablesGeneradas = new List<double>();

            for (int i = 0; i < tamanio; i++)
            {
                variablesGeneradas.Add(this.generarVariableUniforme(limInf, limSup));
            }

            return variablesGeneradas;
        }

        public List<double> generarListaVariablesExponenciales(double lambda, int tamanio)
        {
            List<double> variablesGeneradas = new List<double>();

            for (int i = 0; i < tamanio; i++)
            {
                variablesGeneradas.Add(this.generarVariableExponencialConLambda(lambda));
            }

            return variablesGeneradas;
        }

        public List<double> generarListaVariablesNormales(double media, double desviacion, int tamanio)
        {
            List<double> variablesGeneradas = new List<double>();

            for (int i = 0; i < tamanio/2; i++)
            {
                variablesGeneradas.AddRange(this.generarVariableNormal(media, desviacion));
            }

            if (tamanio % 2 != 0)
                variablesGeneradas.Add(this.generarVariableNormal(media, desviacion)[0]);

            return variablesGeneradas;
        }
    }
}
