using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using TP4.Classes.Generadores;

namespace TP4.Classes
{
    class Ejercicio24
    {
        private int lastResult = -1;
        private readonly PMF firstThrow;
        private PMF currentThrow;
        private bool firstDone;
        private Dictionary<int, PMF> secondThrowProbabilities;
        private readonly int strikePoints;
        private readonly int sparePoints;
        private readonly int threshold;
        private RandomGenerator generator;
        public readonly Montecarlo montecarlo = new Montecarlo(7);

        private void SetSecondThrow()
        {
            currentThrow = GetSecondProbabilities(lastResult);
        }

        private void SetFirstThrow()
        {
            currentThrow = firstThrow;
        }

        private Action SetThrow()
        {
            if (firstDone) return SetSecondThrow;

            return SetFirstThrow;
        }

        public Ejercicio24(int minPrimerTirada, int maxPrimerTirada, double[] probPrimerTirada, int strike, int spare, int limite, Dictionary<int, PMF> segundaTiradaProb, string generator)
        {
            firstThrow = new PMF(minPrimerTirada, maxPrimerTirada, probPrimerTirada);
            firstDone = false;
            secondThrowProbabilities = segundaTiradaProb;
            strikePoints = strike;
            sparePoints = spare;
            threshold = limite;
            SetRandomGenerator(generator);
        }

        private double Computation(double value)
        {
            SetThrow().Invoke();

            int result = -1;
            int low = currentThrow.GetLowerBound();
            int up = currentThrow.GetUpperBound();
            Dictionary<int, double> massFunction = currentThrow.GetMassFunction();
            double accum = 0;
            for (int i = low; i <= up; i++)
            {
                accum += massFunction[i];
                if (value < accum)
                {
                    result = i;
                    firstDone = !firstDone;
                    break;
                }
            }
            lastResult = result;
            return result;
        }

        private void SetRandomGenerator(string type)
        {
            generator = SelectRandomGenerator(type);
        }

        private static RandomGenerator SelectRandomGenerator(string type)
        {
            type = type.ToLower().Trim();
            switch (type)
            {
                case "crypto":
                    return new CryptoGenerator();
                case "standard":
                    return new StandardGenerator();
                case "lcg":
                    return new LCG(30, 19, 16, 29);
                case "mcg":
                    return new MCG(7, 5, 16);
                default:
                    return new CryptoGenerator();
            }
        }

        /// <summary>
        /// genera un numero aleatorio uniformemente distribuido entre 0 y 1 
        /// </summary>
        /// <returns></returns>
        private double RNG()
        {
            double number = generator.GetNextRandomNumber();
            return General.TruncateDecimal(number, 2);
        }

        /// <summary>
        /// Metodo para calcular los puntos correspondientes al ejercicio24
        /// </summary>
        /// <param name="values">Valores obtenidos con los calculos previos, en este caso pinos tirados</param>
        /// <returns>Si se tiro 10 en el primer tiro: strike, si se tiro 10 en el segundo tiro spare, sino la suma de los puntos</returns>
        private double GetPoints(IList<double> values)
        {
            if (values[0] == 10) return strikePoints;

            double points = values[0] + values[1];

            return points == 10 ? sparePoints: points;
        }

        public double[] ComputeMontecarlo(int rounds)
        {
            for(int i = 0; i < rounds; i++)
            {
                montecarlo.ComputeNextVector(RNG,Computation, GetPoints);
            }

            return montecarlo.GetLastVector();
        }

        public List<double[]> ComputeMontecarlo(int rounds, int lowerBound, int upperBound)
        {

            List<double[]> inInterval = new List<double[]>();
            for (int i = 0; i < rounds; i++)
            {
                montecarlo.ComputeNextVector(RNG, Computation, GetPoints);
                if(i+1 >= lowerBound && i+1 < upperBound)
                {
                    inInterval.Add(montecarlo.GetLastVector());
                }
            }
            return inInterval;
        }

        public string ComputeMontecarloHistory(int rounds)
        {
            StringBuilder sb = new StringBuilder("{");
            sb.Append(Environment.NewLine);
            for (int i = 0; i < rounds; i++)
            {
                montecarlo.ComputeNextVector(RNG, Computation, GetPoints);
                sb.Append(montecarlo.LastVectorToString());
                sb.Append(Environment.NewLine);
            }
            sb.Append("}");

            return sb.ToString();
        }

        public bool SurpassedThreshold()
        {
            double[] lastVector = montecarlo.GetLastVector();

            int totalPoints = (int) lastVector[lastVector.Length - 1];

            return totalPoints > threshold;
        }

        private PMF GetSecondProbabilities(int currentPoints)
        {
            return secondThrowProbabilities[currentPoints];
        }
    }
}
