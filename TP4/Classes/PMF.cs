using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    class PMF
    {
        private readonly int lowerBound;
        private readonly int upperBound;
        private readonly Dictionary<int, double> massFunction;

        //Getters
        public int GetUpperBound()
        {
            return upperBound;
        }
        public int GetLowerBound()
        {
            return lowerBound;
        }
        public Dictionary<int,double> GetMassFunction()
        {
            return massFunction;
        }

        public PMF(int lowerBound, int upperBound, double[] probabilitiesVector)
        {
            if (probabilitiesVector.Length - 1 != upperBound - lowerBound )
            {
                ArgumentOutOfRangeException argumentOutOfRangeException = new ArgumentOutOfRangeException();
                throw argumentOutOfRangeException;
            }
            if (!ValidateProbabilitiesVector(probabilitiesVector))
            {
                throw new ArgumentException(); 
            }

            this.lowerBound = lowerBound;
            this.upperBound = upperBound;
            this.massFunction = GetProbabilities(probabilitiesVector);
        }

        private bool ValidateProbabilitiesVector(double[] vector) 
        {
            double accumulator = 0;
            for(int i = 0; i < vector.Length; i++)
            {
                accumulator += vector[i];
            }

            return accumulator == 1;
        }
        private Dictionary<int, double> GetProbabilities(double[] probabilitiesVector)
        {
            Dictionary<int, double> probabilities = new Dictionary<int, double>();
            for(int i = 0; i <= upperBound - lowerBound; i++)
            {
                probabilities.Add(lowerBound + i, probabilitiesVector[i]);
            }

            return probabilities;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Limite inferior: ");
            sb.Append(lowerBound);
            sb.Append(" Limite Superior: ");
            sb.Append(upperBound);
            sb.Append(Environment.NewLine);
            foreach (KeyValuePair<int, double> pair in massFunction)
            {
                sb.Append(pair.Key);
                sb.Append(" -->");
                sb.Append(pair.Value);
                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}
