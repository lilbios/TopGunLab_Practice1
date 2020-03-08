using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.GameStates
{
    public interface IState {
        public void Handle(Match match);
        public void Start();
    }
}
