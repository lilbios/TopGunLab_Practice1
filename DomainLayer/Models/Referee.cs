using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Models
{
    public class Referee
    {
        public string Name { get; private set; }
        public int FavouriteTeam { get; private set; }
        public Referee(string name , int  favouriteTeam)
        {
            Name = name;
            FavouriteTeam = favouriteTeam;
        }

        public void GiveYellowCard()
        {

        }
        public void GiveRedCard()
        {

        }
        public void StartMatch() { 
        
        }
        public void MakeHalfTime() { 
        }
    }
}
