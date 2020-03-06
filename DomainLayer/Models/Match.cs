using DomainLayer.GameStates;
using DomainLayer.MatchSnapShoot;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Models
{
    public class Match
    {
        public IState State { get; set; }
        public DateTime DateMatch { get; private set; }
        public string Stadium { get; private set; }
        public int GameTime { get; private set; } = 90;
        public int PassedTime { get; private set; } = 0;
        public Team Team1 { get; private set; }
        public Team Team2 { get; private set; }
        public int FirstTeamScore { get; set; }
        public int SecondTeamScore { get;set; }

        public Match(string stadium,DateTime date)
        {
            Stadium = stadium;
            DateMatch = date;
        }

        public Memento CreateSnapShoot() {

            return new Memento(DateMatch,Stadium,FirstTeamScore,SecondTeamScore);
        }
        public void PrintMathResult(СareTaker careTaker)
        {

        }
        

    }
}
