using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HomeWork
{
    static class LinqWorker
    {

        public static int Factorial(int n)
            => Enumerable.Range(1, n)
            .Aggregate((x, y) => x * y);
       
    }
}
