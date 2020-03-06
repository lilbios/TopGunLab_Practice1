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
        public void ToCheerUp(MyList<Player> players)
        {

        }
        public void ToDemoralize(MyList<Player> players)
        {

        }

    }
}
