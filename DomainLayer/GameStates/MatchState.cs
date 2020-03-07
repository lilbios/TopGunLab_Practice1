using DomainLayer.Models;
using InfrastructureLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.GameStates
{
   public  class MatchState : IState
    {
        public Referee Referee { get; private set; }
        public int MatchTime { get; set; } = 90;
        public int ScoreTeam1 { get; private set; }
        public int ScoreTeam2 { get; private set; }
        public Team Team1 { get; private set; }
        public Team Team2 { get; private set; }
    
       

        public MatchState(Team firstTeam, Team secondTeam, Referee referee)
        {
            Team1 = firstTeam;
            Team2 = secondTeam;
            Referee = referee;
        }
        public void StartMatch()
        {
            var random = SingletonRandom.GetRandom();

            for (int i = 0; i <= MatchTime; i++) {
                if (i == 45) { 
                    
                }
                if (i == 90) {
                    MatchTime = Referee.GiveAdditionalTime();
                }
                if (Team1.TotalSkillTeam > Team2.TotalSkillTeam)
                {

                }
                else if (Team1.TotalSkillTeam > Team2.TotalSkillTeam)
                {

                }
                else {
                    break;
                }
            }
        }

        public void Hanle(Match match)
        {
            match.State = new OverTimeState(Team1,Team2,Referee);
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public bool IsOver(int score_1, int score_2)
        {
            return (score_1 > score_2 || score_1 < score_2);
        }
    }
}
