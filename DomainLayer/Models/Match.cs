using DomainLayer.GameStates;
using DomainLayer.MatchSnapShoot;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Models
{
    public class Match
    {
        delegate void GetResult(СareTaker careTaker);
        public  IState State { get;  set; }
        public DateTime DateMatch { get; private set; }
        public string Stadium { get; private set; }
        public Match(string stadium,DateTime date)
        {
            Stadium = stadium;
            DateMatch = date;
        }
        public void PrintMathResult(СareTaker careTaker)
        {
            Console.WriteLine($"");
        }
        
        

    }
}
