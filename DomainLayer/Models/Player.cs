using InfrastructureLayer;
using ListImpl;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Models
{
    public class Player:IComparable
    {
        public string Name { get; private set; }
        public int Number { get; private set; }
        public int Skill { get; private set; }
        public double Lucky { get; private set; }
        public Player(string name, int number, int skill, double lucky)
        {
            Name = name;
            Number = number;
            Skill = skill;
            Lucky = lucky;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
        public bool KickBall(Team enemyTeam,int teamSkill)
        {
            var random = SingletonRandom.GetRandom();
            int percentEnemyPlayersSkill = (enemyTeam.Players.Count * 80) / 100;
            bool[] gamefactors = new bool[2];
            gamefactors[0] = teamSkill > enemyTeam.TotalSkillTeam;
            foreach (var item in enemyTeam.Players)
            {
                if (Skill > item.Skill) --percentEnemyPlayersSkill;
            }
            gamefactors[1] = percentEnemyPlayersSkill <= 0;
            return gamefactors[random.Next(0,1)];


        }
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType()) return false;
            Player player = obj as Player;
            return Name == player.Name && Number == player.Number && Skill == player.Skill && Lucky == player.Lucky;
        }
        public override int GetHashCode()
        {

            int hash = 17;
            hash = hash ^ Name.GetHashCode();
            hash = hash ^ Number.GetHashCode();
            hash = hash ^ Skill.GetHashCode();
            return hash;
        }

    }
}
