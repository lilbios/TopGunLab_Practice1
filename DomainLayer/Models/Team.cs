using ListImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static DomainLayer.Models.Referee;

namespace DomainLayer.Models
{
    public class Team
    {
        public string TeamName { get; private set; }
        public double TotalSkillTeam { get; set; }
        public Coach Coach { get; private set; }
        public MyList<Player> Players { get; private set; }
        public Team(string name, Coach newcoach)
        {
            Players = new MyList<Player>();
            Coach = newcoach;
        }

        public void AddPlayerToTeam(Player player)
        {
            if (Players.Count != 11)
            {
                Players.Add(player);
                TotalSkillTeam = MeasureTotalTeamSkill();
            };
        }
        public void AddCoach(Coach coach)
        {

            if (Coach == null) Coach = coach;
        }
        public void RemovePlayer(Player player)
        {
            if (Players.Count > 0)
            {
                Players.Remove(player);
            }

        }

        //Here calculates total team skill with formula: (playerN.skill * playerN.luck +...+player11.skill * player11.luck) * coach.luck.
        //This coefficient can be changed druing the match.
        public double MeasureTotalTeamSkill() => Players.Select(p => p.Skill * p.Lucky).Sum() * Coach.Lucky;

    }
}
