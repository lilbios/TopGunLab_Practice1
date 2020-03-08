using DomainLayer.GameStates;
using DomainLayer.MatchSnapShoot;
using DomainLayer.Models;
using InfrastructureLayer;
using ListImpl;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ConsoleUI
{
    public delegate void ViewReuslt(СareTaker сareTaker);
    class Program
    {
        static void Main(string[] args)
        {

            var random = SingletonRandom.GetRandom();
            var match = new Match("Stadium#1", DateTime.Now);
            ViewReuslt ResultViewer = match.PrintMatchResult;
           var referee = new Referee("Kassai Viktor",random.Next(0,1));
            Parser parser = new Parser();
            Team team1 = parser.GetTeam();
            Team team2 = parser.GetTeam();
            
            Func<int, int, bool> isMatchOver = delegate(int score1,int score2) { return score1 > score2 || score2 > score1; };
            //Weathe coeficients that have got influence on match
            int[] weatherCoefficiend = (int[])Enum.GetValues(typeof(Weather));
            var matchState = new MatchState(null,null,null);
            match.MatchNotify += match.StartMatch;
            match.MatchStageNotify += match.NextMatchStage;
            match.StartMatch();

            if (isMatchOver(match.State.ScoreTeam1, match.State.ScoreTeam2)) {
                match.NextMatchStage(match);
                match.StartMatch();
            } else if (isMatchOver(match.State.ScoreTeam1, match.State.ScoreTeam2)) {
                match.NextMatchStage(match);
            }
            ResultViewer(match.State.CareTaker);
            
        }
    }
}
