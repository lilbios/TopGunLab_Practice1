using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.GameStates
{
   public  class PenaltySerieState
    {
        public Team Team1 { get; private set; }
        public Team Team2 { get; private set; }
        public PenaltySerieState(Team firstTeam, Team secondTeam)
        {
                
        }
    }
}
