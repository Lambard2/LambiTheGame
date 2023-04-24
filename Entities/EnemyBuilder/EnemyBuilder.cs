using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Game.Entities.Interfaces;
namespace Game.Entities.EnemyBuilder
{
    public class EnemyBuilder : IBuilder
    {
        IEntity Enemy = new Enemy();
        public void SetAttack(int Attack)
        {
            Enemy.Attack = Attack;
        }
        public void SetHealth(int Health)
        {
            Enemy.Health = Health;
        }
        public void SetDefense(int Defense)
        {
            Enemy.Defense = Defense;
        }
        public void SetMagicPower(int MagicPower)
        {
            Enemy.MagicPower = MagicPower;
        }
        public void Reset()
        {
            this.Enemy = new Enemy();
        }
        public IEntity GetProduct()
        {
            IEntity result = Enemy;
            Reset();
            return result;
        }
    }
}