using DomainLayer.MatchSnapShoot;
using DomainLayer.Models;
using InfrastructureLayer;
using System.Collections.Generic;
using System;

namespace DomainLayer.GameStates
{
    public class PenaltySerieState : IState
    {
        public Team Team1 { get; private set; }
        public Team Team2 { get; private set; }
        public int ScoreTeam1 { get; set; }
        public int ScoreTeam2 { get;  set; }
        public int Shots { get; private set; } = 5;
        public СareTaker CareTaker { get; }
        public PenaltySerieState(Team firstTeam, Team secondTeam)
        {
            Team1 = firstTeam;
            Team2 = secondTeam;
            CareTaker = new СareTaker();

        }

        public void Start()
        {
            var random = SingletonRandom.GetRandom();
            string teamWinner = "None";
            var teams = new List<Team>();         
            int queue = 0;
            int j = 0;
            teams.Add(Team1);
            teams.Add(Team2);

            for (int i = 0; i < Shots; i++)
            {

                var currentPlayer = teams[queue].Players.FindByIndex(j);
                var goal = currentPlayer.PenaltyKick();

                if (goal)
                {
                    Console.WriteLine($"{currentPlayer.Name} scores goal!");
                    if (queue == 0)
                    {
                        ++ScoreTeam1;
                    }
                    else
                    {
                        ++ScoreTeam2;
                    }
                    CareTaker.LastState();
                    CareTaker.PushEvent(new Memento(Team1.TeamName, Team2.TeamName, ScoreTeam1, ScoreTeam2));
                }
                else {
                   Console.WriteLine($"{currentPlayer.Name} misses the gates!");
                }
                if (ScoreTeam1 - ScoreTeam2 >= 1)
                {
                    teamWinner = Team1.TeamName;
                }
                else {
                    teamWinner = Team2.TeamName;
                }

            }
            Console.WriteLine($"Team {teamWinner} wins!");
          

        }

        public void Handle(Match match)
        {
            match.State = null;
        }

        public Memento CreateMemento(string team1Title, string team2Title, int score1, int score2)
        {
            return new Memento(team1Title, team2Title, score1, score2);
        }
    }
}
