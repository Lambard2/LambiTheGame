using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Game.Entities.Interfaces;
using Game.Entities.Abilities;

namespace Game.Entities.EnemyBuilder
{
    public class Enemy : IEntity
    {
        public int Attack {get;set;}
        public int Defense {get;set;}
        public int Health {get;set;}
        public int MagicPower {get;set;}
        public IAbilityStrategy Ability {get;set;}
        public void AttackMove(IEntity target)
        {
            if(target.Defense >= this.Attack)
            {
                target.Health -= 1;
            }
            else
            {
            target.Health -= this.Attack-target.Defense;
            }
        }
        public void UseAbility(IEntity target)
        {
            throw new NotImplementedException();
        }
    }
}