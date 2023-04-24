using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Game.Entities.Interfaces;
using Game.Entities.Abilities;

namespace Game.Entities.HeroBuilder
{
    public class Hero : IEntity
    {
        public int Attack {get;set;}
        public int Defense {get;set;}
        public int Health {get;set;}
        public int MagicPower {get;set;}
        public IAbilityStrategy Ability {get;set;}
        
        public void AttackMove(IEntity target)
        {
            target.Health -= Attack-target.Defense;
        }
        public void UseAbility(IEntity target)
        {
            Ability.UseAbility(target, this);
        }
    }
}