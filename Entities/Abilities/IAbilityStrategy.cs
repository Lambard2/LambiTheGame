using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Game.Entities.Interfaces;
using Game.Entities.HeroBuilder;
namespace Game.Entities.Abilities
{
    public interface IAbilityStrategy
    {
        void UseAbility(IEntity enemy, IEntity caster);
    }
}