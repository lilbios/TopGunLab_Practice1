using DomainLayer.MatchSnapShoot;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.GameStates
{
    public interface IState {
        public int ScoreTeam1 { get; set; }
        public int ScoreTeam2 { get; set; }
        public СareTaker CareTaker { get; }
        public void Handle(Match match);
        public void Start();
    }
}
