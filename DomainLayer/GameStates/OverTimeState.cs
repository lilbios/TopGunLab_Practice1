using DomainLayer.Models;
using InfrastructureLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.GameStates
{
    public class OverTimeState : IState
    {
        public Referee Referee { get; private set; }
        public int MatchTime { get; set; } = 30;
        public int ScoreTeam1 { get; private set; }
        public int ScoreTeam2 { get; private set; }
        public Team Team1 { get; private set; }
        public Team Team2 { get; private set; }


        public OverTimeState(Team firstTeam, Team secondTeam,Referee referee)
        {
            Team1 = firstTeam;
            Team2 = secondTeam;
            Referee = referee;
        }

      

        public void Start()
        {
            var random = SingletonRandom.GetRandom();
            for (int i = 0; i <= MatchTime; i++)
            {
                if (i == 15)
                {

                }
                if (i == 30)
                {
                    MatchTime = Referee.GiveAdditionalTime();
                }
                else if (Team1.TotalSkillTeam > Team2.TotalSkillTeam)
                {

                }
                else
                {
                    break;
                }
            }
           
        }
        

        public void Hanle(Match match)
        {
            match.State = new PenaltySerieState(Team1,Team2);
        }


        public bool IsOver(int score_1, int score_2)
        {
            return (score_1 > score_2 || score_1 < score_2);
        }
    }
}
