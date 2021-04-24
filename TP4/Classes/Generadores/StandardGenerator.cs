using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp4.Classes.Generadores
{
    //Una clase que envuelve el generador de numeros aleatorios propio de c#
    public class StandardGenerator : RandomGenerator
    {
        private readonly Random random;
        private readonly int seed;

        private int randomNumber;
        public StandardGenerator(int seed)
        {
            this.seed = seed;
            this.randomNumber = seed;
            random = new Random(seed);
        }

        //Implementamos la Interface RandomGenerator
        public int GetSeed()
        {
            return seed;
        }

        public float GetLastRandomNumber()
        {
            return randomNumber;
        }

        //Obtiene el siguiente numero aleatorio
        public float GetNextRandomNumber()
        {
            return (float) random.NextDouble();
        }
    }
}
