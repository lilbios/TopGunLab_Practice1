using DomainLayer.GameStates;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.MatchSnapShoot
{
    public class СareTaker
    {
        //CareTaker save in History all states of match
        private Stack<Memento> History { get; set;}
        public СareTaker()
        {
            History = new Stack<Memento>();
        }
        public Memento LastState() => History.Pop();
        public void PushEvent(Memento memento) => History.Push(memento); 
    }
}
