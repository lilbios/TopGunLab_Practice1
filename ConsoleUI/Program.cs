using DomainLayer.GameStates;
using DomainLayer.Models;
using InfrastructureLayer;
using ListImpl;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            var random = SingletonRandom.GetRandom();
            Parser parser = new Parser();
            Team team1 = parser.GetTeam();
            Team team2 = parser.GetTeam();
            Func<int, int, bool> isMatchOver;

            int[] weatherCoefficiend = (int[])Enum.GetValues(typeof(Weather));
            var match = new Match("Stadium#1",DateTime.Now);
            var matchState = new MatchState(null,null,null);
            match.MatchNotify += match.StartMatch;
            match.MatchStageNotify += match.NextMatchStage;
            match.StartMatch();

            if (true) {
                match.NextMatchStage(match);
            } else if (true) {
                match.NextMatchStage(match);
            }
            else { 
            
            }




        }
    }
}
