using ListImpl;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Models
{
    public delegate void RefereeEventHandler();
    public class Referee
    {
        public string Name { get; private set; }
        public int FavouriteTeam { get; private set; }
        public MyList<Player> Violators { get; private set; }
        public Referee(string name, int favouriteTeam)
        {
            Name = name;
            FavouriteTeam = favouriteTeam;
            Violators = new MyList<Player>();
        }

        public bool GiveYellowCard(Player player)
        {
            foreach (var _player in Violators)
            {
                if (_player.Equals(player))
                {
                    Console.WriteLine($"It's a second yellow card given to player {player.Name}");
                    Violators.Remove(player);
                    GiveRedCard(player);
                    return true;
                }
            }
            Violators.Add(player);
            return false ;
        }
            
        public bool GiveRedCard(Player player)
        {
            Console.WriteLine($"Red card!Player number{player.Number} leaves football field");
        }
        public void StartMatch()
        {
            Console.WriteLine("Teams are ready.Referee starts the match!"); 
        }
        public void MakeHalfTime()
        {
            Console.WriteLine("The referee takes out the whistle! Teams go for a break");
        }
    }
}
