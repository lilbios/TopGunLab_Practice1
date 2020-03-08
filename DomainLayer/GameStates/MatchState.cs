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
        public СareTaker CareTaker { get; private set; }



        public MatchState(Team firstTeam, Team secondTeam, Referee referee)
        {
            Team1 = firstTeam;
            Team2 = secondTeam;
            Referee = referee;
            CareTaker = new СareTaker();
        }


        public void Handle(Match match)
        {
            match.State = new OverTimeState(Team1,Team2,Referee);
        }

        public void Start()
        {
            var random = SingletonRandom.GetRandom();
            Team oponentTeam;
            Team currentTeam;
            Player currentPlayer;
            var teams = new List<Team>();
            int index = 0;
            var goal = false;
            teams.Add(Team1);
            teams.Add(Team2);
            for (int i = 0; i <= MatchTime; i++)
            {
                index = random.Next(0, 1);
                if (i == 45)
                {
                    Referee.MakeHalfTime(Team1.TeamName);
                    Referee.MakeHalfTime(Team2.TeamName);
                }
                if (i == 90)
                {
                    MatchTime = Referee.GiveAdditionalTime();
                }
                currentTeam = teams[index];
                oponentTeam = teams[index ^= 1];
                currentPlayer = currentTeam.Players.FindByIndex(random.Next(0,10));
                goal = currentPlayer.KickBall(oponentTeam, teams[index].TotalSkillTeam);
                if (goal)
                {
                    Console.WriteLine($"{currentPlayer.Name} scores goal!");
                    if (index == 0)
                    {
                        ++ScoreTeam1;
                    }
                    else {
                        ++ScoreTeam2;
                    }
                    CareTaker.PushEvent(new Memento(Team1.TeamName, Team2.TeamName,ScoreTeam1, ScoreTeam2));
                }
            }
        }


        public Memento CreateMemento(string team1Title, string team2Title, int score1, int score2) {
            return new Memento(team1Title,team2Title,score1,score2);
        }
        
    }
}
