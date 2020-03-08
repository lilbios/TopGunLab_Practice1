using DomainLayer.MatchSnapShoot;
using DomainLayer.Models;
using InfrastructureLayer;
using System;
using System.Collections.Generic;
using System.Text;
using static DomainLayer.Models.Match;
using static DomainLayer.Models.Referee;
using static DomainLayer.Models.Team;

namespace DomainLayer.GameStates
{
   public  class MatchState : IState
    {
        
        public Referee Referee { get; private set; }
        public int MatchTime { get; set; } = 90;
        public int ScoreTeam1 { get; set; }
        public int ScoreTeam2 { get;  set; }
        public Team Team1 { get; private set; }
        public Team Team2 { get; private set; }
    
       

        public MatchState(Team firstTeam, Team secondTeam, Referee referee)
        {
            Team1 = firstTeam;
            Team2 = secondTeam;
            Referee = referee;
        }


        public void Handle(Match match)
        {
            match.State = new OverTimeState(Team1,Team2,Referee);
        }

        public void Start()
        {
            var random = SingletonRandom.GetRandom();
            List<Team> teams = new List<Team>();
            teams.Add(Team1);
            teams.Add(Team2);




            for (int i = 0; i <= MatchTime; i++)
            {
                if (i == 45)
                {
                    Referee.MakeHalfTime(Team1.TeamName);
                    Referee.MakeHalfTime(Team2.TeamName);
                }
                if (i == 90)
                { 
                }
               
            }
        }
        public Memento CreateMemento(string team1Title, string team2Title, int score1, int score2) {
            return new Memento(team1Title,team2Title,score1,score2);
        }
        
    }
}
