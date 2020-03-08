using DomainLayer.MatchSnapShoot;
using DomainLayer.Models;
using InfrastructureLayer;

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

            for (int i = 0; i < Shots; i++)
            {

            }


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
