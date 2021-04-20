using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Classes
{
    class Montecarlo
    {
        private double[] previousVector;
        private double[] lastVector;

        public double[] GetPreviousVector()
        {
            return previousVector;
        }

        public double[] GetLastVector()
        {
            return lastVector;
        }

        //El tamaño del vector se calcula como: 2 * N + 3
        //Donde N es igual a la cantidad de operaciones intermedias
        public Montecarlo(int vectorSize)
        {
            previousVector = new double[vectorSize];
            lastVector = new double[vectorSize];
        }

        public void ComputeNextVector(Func<double> rng, Func<double, double> computation, Func<IList<double>, double> selectValue)
        {
            int length = lastVector.Length;
            double[] middleComputations = new double[length - 3];
            List<double> values = new List<double>();

            for (int i = 0; i < middleComputations.Length; i+=2)
            {
                //Se genera un numero aleatorio
                middleComputations[i] = rng();

                //Se realiza el calculo con el numero generado y se lo guarda en una lista de valores
                middleComputations[i + 1] = computation(middleComputations[i]);
                values.Add(middleComputations[i + 1]);
            }

            //El ultimo vector pasa a ser el anterior
            previousVector = lastVector;
            lastVector = new double[length];

            //Se copia las computaciones al vector final
            middleComputations.CopyTo(lastVector, 1);

            //se aumenta el numero de iteracion correspondiente al lugar 0 del vector
            //se guarda el valor seleccionado en el vector (Length - 2)
            //se realiza la acumulacion correspondiente (Length - 1)
            lastVector[0] = previousVector[0]++;
            double selectedValue = selectValue(values);
            lastVector[length - 2] = selectedValue;
            lastVector[length - 1] = previousVector[length - 1] + selectedValue;
        }

        public string LastVectorToString()
        {
            StringBuilder sb = new StringBuilder("[");
            foreach (double value in lastVector)
            {
                sb.Append(value);
                sb.Append(" ");
            }
            sb.Remove(sb.Length-1, 1);
            sb.Append("]");

            return sb.ToString();
        }

    }
}
