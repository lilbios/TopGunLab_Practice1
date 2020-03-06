using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.MatchSnapShoot
{
    public class Memento
    {
        public DateTime DateMatch { get; private set; }
        public string Stadium { get; private set; }
        public int FirstTeamScore { get; set; }
        public int SecondTeamScore { get; set; }

        public Memento(DateTime dateMatch, string stadium, int score1,int score2 )
        {
            DateMatch = dateMatch;
            Stadium = stadium;
            FirstTeamScore = score1;
            SecondTeamScore = score2;
        }
    }
}
