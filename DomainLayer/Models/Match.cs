using DomainLayer.GameStates;
using DomainLayer.MatchSnapShoot;
using System;
using System.Collections.Generic;
using System.Text;
using static DomainLayer.Models.Match;

namespace DomainLayer.Models
{
    public class Match
    {

        public delegate void MatchEventHandler();
        public delegate void MatchStageHandler(Match match);
        public event MatchEventHandler MatchNotify;
        public event MatchStageHandler MatchStageNotify;

        public  IState State { get;  set; }
        public DateTime DateMatch { get; private set; }
        public string Stadium { get; private set; }
        public Match(string stadium,DateTime date)
        {
            Stadium = stadium;
            DateMatch = date;
        }
        public void PrintMatchResult(СareTaker careTaker)
        {
            var state = careTaker.LastState();
            Console.WriteLine($"{state.FirstTeam}:{state.FirstTeamScore}-{state.SecondTeam}:{state.SecondTeam}");        
        }
        public void StartMatch() {
            MatchNotify?.Invoke();
        }
        public void NextMatchStage(Match match) {
            MatchStageNotify?.Invoke(match);
        }
        
        

    }
}
