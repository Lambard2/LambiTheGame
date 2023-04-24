using System.Collections.Concurrent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Game.Entities.EnemyBuilder;
using Game.Entities.Interfaces;
using Game.Entities.HeroBuilder;
namespace Game.Entities.Abilities
{
    public class AbilityFireball : IAbilityStrategy
    {
        public void UseAbility(IEntity enemy, IEntity caster)
        {
            enemy.Health -= caster.MagicPower;
        }
    }
}