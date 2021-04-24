using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Tp4.Classes.Generadores;

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

        public Ejercicio24(int minPrimerTirada, int maxPrimerTirada, double[] probPrimerTirada, int strike, int spare, int limite, Dictionary<int, PMF> segundaTiradaProb)
        {
            firstThrow = new PMF(minPrimerTirada, maxPrimerTirada, probPrimerTirada);
            firstDone = false;
            secondThrowProbabilities = segundaTiradaProb;
            strikePoints = strike;
            sparePoints = spare;
            threshold = limite;
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

        //La funcion original era la de abajo, la que usa la libreria Random()
        //Me encontre un problema el cual producia que se generara el mismo numero, una y otra vez
        //Investigando, llegue a la conclusion de que es un problema relacionado con los pulsos del clock
        //Y la velocidad con la que se generan los numeros, claramente la libreria Random no estaba pensada
        //Para generar miles y miles de -Dolares- numeros en el mismo Thread, es por este motivo por el cual
        //Opte por utilizar la libreria RNGCryptoServiceProvider, en caso de que usted quiera probar por su
        //Cuenta lo que me llevó a invertir 3 horas de mi vida y, en su defecto, encontrar una solucion
        //El metodo esta debajo y está a la espera de más horas invertidas en él.
        //NO VALE USAR SYSTEM TIMEOUTS.
        //Horas invertidas en intentar solucionarlo: 3 horas.
        private double RNG()
        {
            RandomNumberGenerator rng = new RNGCryptoServiceProvider();
            byte[] byteArray = new byte[8];
            rng.GetBytes(byteArray);
            double cryptic = BitConverter.ToUInt64(byteArray, 0) / (1 << 11);
            double number = cryptic / (double)(1UL << 53);
            return General.TruncateDecimal(number, 2);
        }

        //Este es el metodo curseado
        //private double RNG()
        //{
        //    Random rng = new Random();
        //    double number = rng.NextDouble();
        //    return General.TruncateDecimal(number, 2);
        //}

        //private double RNG()
        //{
        //    int seed = 6;
        //    LCG lcg = new LCG(seed, 3, 3, 7);
        //    return General.TruncateDecimal(lcg.GetNextRandomNumber(), 2);
        //}

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
