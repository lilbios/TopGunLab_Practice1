using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.MatchSnapShoot
{
    public class Memento
    {
        public int FirstTeamScore { get; set; }
        public int SecondTeamScore { get; set; }
        public string FirstTeam { get; private set; }
        public string SecondTeam { get; private set; }


        public Memento(string team1,string team2,int score1,int score2)
        {
            FirstTeam = team1;
            SecondTeam = team2;
            FirstTeamScore = score1;
            SecondTeamScore = score2;
        }
    }
}
