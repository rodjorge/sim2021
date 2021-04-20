using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private double RNG()
        {
            Random rng = new Random();
            return General.TruncateDecimal(rng.NextDouble(), 2);
        }

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
