using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Game.Entities.Abilities;
namespace Game.Entities.HeroBuilder
{
    public class HeroBuilderDirector
    {
        public HeroBuilderDirector(HeroBuilder builder)
        {
            _builder = builder;
        }
        private HeroBuilder _builder;
        public void BuildBarbarian()
        {
            _builder.SetHealth(100);
            _builder.SetAttack(25);
            _builder.SetDefense(10);
            _builder.SetMagicPower(20);
            _builder.SetAbility(new AbilityRage());
        }
        public void BuildSorcerer()
        {
            _builder.SetHealth(75);
            _builder.SetAttack(10);
            _builder.SetDefense(5);
            _builder.SetMagicPower(50);
            _builder.SetAbility(new AbilityFireball());
        }
        public void BuildHealer()
        {
            _builder.SetHealth(80);
            _builder.SetAttack(10);
            _builder.SetDefense(5);
            _builder.SetMagicPower(20);
            _builder.SetAbility(new AbilityHeal());
        }
    }
}