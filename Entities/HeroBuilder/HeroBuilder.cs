using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Game.Entities.Interfaces;
using Game.Entities.Abilities;

namespace Game.Entities.HeroBuilder
{
    public class HeroBuilder : IBuilder
    {
        IEntity Hero = new Hero();
        public void SetAttack(int Attack)
        {
            Hero.Attack = Attack;
        }
        public void SetHealth(int Health)
        {
            Hero.Health = Health;
        }
        public void SetDefense(int Defense)
        {
            Hero.Defense = Defense;
        }
        public void SetAbility(IAbilityStrategy ability)
        {
            Hero.Ability = ability;
        }
        public void SetMagicPower(int MagicPower)
        {
            Hero.MagicPower = MagicPower;
        }
        public void Reset()
        {
            this.Hero = new Hero();
        }
        public IEntity GetProduct()
        {
            IEntity result = Hero;
            Reset();
            return result;
        }
    }
}