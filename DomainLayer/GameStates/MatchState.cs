using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.GameStates
{
   public  class MatchState : IState
    {
        public int MatchTime { get; set; } = 90;
        public Team Team1 { get; private set; }
        public Team Team2 { get; private set; }
        public MatchState(Team firstTeam, Team secondTeam)
        {
            Team1 = firstTeam;
            Team2 = secondTeam;
        }
        public bool Hanle()
        {
            for (int i = 0; i <= MatchTime; i++) {
                if (i == 45) { 
                    
                }
                if (i == 90) { 
                        
                }
            }
            return false;
        }
    }
}
