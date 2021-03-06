﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InfrastructureLayer
{
    public sealed class SingletonRandom
    {
        private static Random _instance;

        public static Random GetRandom()
        {
            if (_instance == null)
            {
                _instance = new Random();
            }
            return _instance;
        }
        public double GetDoubleInRange(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
