using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoRandomNumbers.clases.generadores
{
    public class MCG : RandomGenerator
    {
        private readonly int seed;
        private readonly int multiplier;
        private readonly int modulous;

        private int randomNumber;
        public MCG(int seed, int k, int g)
        {
            this.seed = seed;
            this.randomNumber = seed;
            this.modulous = (int) Math.Pow(2, g);
            this.multiplier = 3 + 8 * k;
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
            CalculateNextRandomNumber();
            return RandomNumberToFloat();
        }


        //Se calcula el siguiente numero pseudo aleatorio
        private void CalculateNextRandomNumber()
        {
            randomNumber = (this.multiplier * this.randomNumber) % modulous;
        }

        //Se normaliza el numero aleatorio de modo que este en el intervalo [0;1]
        private float RandomNumberToFloat()
        {
            float normalized = (float)this.randomNumber / (modulous - 1);
            return normalized;
        }
    }
}
