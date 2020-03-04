using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Models
{
    enum Weather { 
            Sunny = 0,
            Rainy = -5,
            Windy = -2
    }
    public class Match
    {
        public DateTime DateMatch { get; private set; }
        public string Stadium { get; private set; }
        public int PassedTime { get; private set; }


        public Match(string stadium,DateTime dateTime)
        {
            Stadium = stadium;
            DateMatch = dateTime; 
        }

        public bool StartMatch(Team team1,Team team2,Referee referee)
        {
            int gameTime = 90;
            for (int i = 0; i < gameTime; i++)
            {

            }
            return false;
        }

        public bool StartPenaltySeries(Team team1, Team team2)
        {
            return false;
        }
        public bool StartOverTime(Team team1, Team team) {
            return false;
        }

        public string GetMatchResult() {
            return null;
        }

    }
}
