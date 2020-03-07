using DomainLayer.Models;
using InfrastructureLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.GameStates
{
    public class PenaltySerieState : IState
    {

        public Team Team1 { get; private set; }
        public Team Team2 { get; private set; }
        public int ScoreTeam1 { get; private set; }
        public int ScoreTeam2 { get; private set; }
        public int Shots { get; private set; } = 5;
        public PenaltySerieState(Team firstTeam, Team secondTeam)
        {
            Team1 = firstTeam;
            Team2 = secondTeam;

        }

        public void Start()
        {
            var random = SingletonRandom.GetRandom();
            for (int i = 0; i < Shots; i++)
            {

            }


        }

        public void Hanle(Match match)
        {
            match.State = null;
        }

        public bool IsOver(int score_1, int score_2)
        {

        }
    }
}
