using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.GameStates
{
   public  class OverTimeState : IState
    {
        public int MatchTime { get; set; } = 30;
        public Team Team1 { get; private set; }
        public Team Team2 { get; private set; }
        public OverTimeState(Team firstTeam, Team secondTeam)
        {
            Team1 = firstTeam;
            Team2 = secondTeam;
        }
        public bool StartOverTime() {
            for (int i = 0; i <= MatchTime; i++) { 
                        
            }
            return false;
        }
        public bool Hanle(Match match)
        {
            match.State = new PenaltySerieState(Team1,Team2);
            return false;
        }
    }
}
