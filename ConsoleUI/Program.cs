using DomainLayer.GameStates;
using DomainLayer.Models;
using InfrastructureLayer;
using ListImpl;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            var random = SingletonRandom.GetRandom();
            Type myClassType = Type.GetType("Weather");
            Console.WriteLine();




        }
    }
}
