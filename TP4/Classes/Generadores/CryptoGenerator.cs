using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace TP4.Classes.Generadores
{
    class CryptoGenerator : RandomGenerator
    {
        private double randomNumber;
        private RandomNumberGenerator generator;

        public CryptoGenerator()
        {
            this.randomNumber = 0;
            this.generator = new RNGCryptoServiceProvider();
        }
        public float GetLastRandomNumber()
        {
            return (float)randomNumber;
        }

        public float GetNextRandomNumber()
        {
            byte[] byteArray = new byte[8];
            generator.GetBytes(byteArray);
            double cryptic = BitConverter.ToUInt64(byteArray, 0) / (1 << 11);
            double number = cryptic / (double)(1UL << 53);
            return (float)number;
        }

        public int GetSeed()
        {
            return -1;
        }
    }
}
