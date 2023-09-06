using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Classes.Generadores
{
    public class LCG : RandomGenerator
    {
        private readonly int seed;
        private readonly int multiplier;
        private readonly int increment;
        private readonly int modulous;

        private int randomNumber;

        public LCG() : this((int) DateTime.Today.Ticks){}
        public LCG(int seed) : this(seed, 6, 3, 7) {}
        public LCG(int seed, int k, int g, int increment)
        {
            this.seed = seed;
            this.multiplier = 1 + 4 * k;
            this.increment = increment;
            this.modulous = (int) Math.Pow(2, g);
            this.randomNumber = seed;
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
            randomNumber = (this.multiplier * this.randomNumber + this.increment) % modulous;
        }

        //Se normaliza el numero aleatorio de modo que este en el intervalo [0;1]
        private float RandomNumberToFloat()
        {
            float normalized = (float) this.randomNumber / modulous;
            return normalized;
        }
    }
}
