﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Classes.Generadores
{
    interface RandomGenerator
    {

        int GetSeed();
        float GetLastRandomNumber();
        float GetNextRandomNumber();
    }
}
