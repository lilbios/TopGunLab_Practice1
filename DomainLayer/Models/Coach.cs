using ListImpl;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Models
{
    public class Coach
    {
        public string Name { get; private set; }
        public double Lucky { get; private set; }
        public bool Mood { get; set; }

        public Coach(string name, double lucky)
        {
            Name = name;
            Lucky = lucky;
        }
        public MyList<Player> ToCheerUp(MyList<Player> players)
        {
            return null;
        }
        public MyList<Player> ToDemoralize(MyList<Player> players)
        {
            return null;
        }
    }
}
