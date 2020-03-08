using DomainLayer.MatchSnapShoot;
using DomainLayer.Models;
using InfrastructureLayer;
using System;
using System.Collections.Generic;
using System.Text;
using static DomainLayer.Models.Match;

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

        public event IState.MatchBreak OnBreak;

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
                   
                }

                
            }
           
        }
        

        public void Handle(Match match)
        {
            match.State = new PenaltySerieState(Team1,Team2);
        }


     
        public Memento CreateMemento(string team1Title, string team2Title, int score1, int score2)
        {
            return new Memento(team1Title,team2Title,score1,score2);
        }
    }
}
