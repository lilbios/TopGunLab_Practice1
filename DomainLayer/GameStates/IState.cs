using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.GameStates
{
    public interface IState
    {
        public void Hanle(Match match);
        public void Start();
        public bool IsOver(int score_1,int score_2);
    }
}
