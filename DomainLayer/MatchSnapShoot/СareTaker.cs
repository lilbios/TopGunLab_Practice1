using DomainLayer.GameStates;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.MatchSnapShoot
{
    public class СareTaker
    {
        public Memento Memento{get;set;}
        public IState[] History { get; set;}
        public СareTaker()
        {
            History = new IState[3];
        }

    }
}
