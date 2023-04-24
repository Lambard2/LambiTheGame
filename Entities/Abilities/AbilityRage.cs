using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Game.Entities.Interfaces;
namespace Game.Entities.Abilities
{
    public class AbilityRage : IAbilityStrategy
    {
        public void UseAbility(IEntity enemy, IEntity caster)
        {
            caster.Attack += caster.MagicPower;
        }
    }
}