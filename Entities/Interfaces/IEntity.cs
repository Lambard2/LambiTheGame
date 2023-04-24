using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Game.Entities.Abilities;

namespace Game.Entities.Interfaces
{
    public interface IEntity
    {
        int Attack {get;set;}
        int Defense {get;set;}
        int Health {get;set;}
        int MagicPower {get;set;}
        IAbilityStrategy Ability {get;set;}
        void AttackMove(IEntity target);
        void UseAbility(IEntity target);
    }
}