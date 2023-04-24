using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Game.Entities.EnemyBuilder;
using Game.Entities.HeroBuilder;
using Game.Entities.Interfaces;

namespace Game.Entities.EnemyBuilder
{
    public class EnemyBuilderDirector
    {
        public EnemyBuilderDirector(EnemyBuilder builder)
        {
            _builder = builder;
        }
        private EnemyBuilder _builder;
        public void BuildEasyEnemy()
        {
            _builder.SetHealth(20);
            _builder.SetAttack(1);
            _builder.SetDefense(0);
        }
        public void BuildMediumEnemy()
        {
            _builder.SetHealth(50);
            _builder.SetAttack(10);
            _builder.SetDefense(5);
        }
        public void BuildHardEnemy()
        {
            _builder.SetHealth(100);
            _builder.SetAttack(25);
            _builder.SetDefense(10);     
        }
        public void BuildImpossibleEnemy()
        {
            _builder.SetHealth(9999);
            _builder.SetAttack(9999);
            _builder.SetDefense(9999);
        }
        
    }
}