using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Game.UI.State;
using Game.Entities.EnemyBuilder;
using Game.Entities.Interfaces;
using Game.Entities.HeroBuilder;

namespace Game.UI.Menu
{
    public class UIDiffSelect : UIState
    {
        public UIDiffSelect(IEntity hero){
            Hero = hero;
            EnemyBuilderDirector = new(EnemyBuilder);
        }
        int choice;
        public IEntity Hero;
        public EnemyBuilder EnemyBuilder = new();
        EnemyBuilderDirector EnemyBuilderDirector;
        
        public override void RenderUI(UICreator creator)
        {
            Console.Clear();
            choice = UISkeleton.Choice(1,10,"Easy","Normal","Hard","Impossible","Back");            
            switch(choice){
                case 0:
                    EnemyBuilderDirector.BuildEasyEnemy();
                    creator.ChangeState(new UIPlayerTurn(EnemyBuilder.GetProduct(), Hero, new List<string>()));
                    Console.Clear();
                break;
                case 1:
                    EnemyBuilderDirector.BuildMediumEnemy();
                    creator.ChangeState(new UIPlayerTurn(EnemyBuilder.GetProduct(), Hero, new List<string>()));
                    Console.Clear();
                break;
                case 2:
                    EnemyBuilderDirector.BuildHardEnemy();
                    creator.ChangeState(new UIPlayerTurn(EnemyBuilder.GetProduct(), Hero, new List<string>()));
                    Console.Clear();
                break;
                case 3:
                    EnemyBuilderDirector.BuildImpossibleEnemy();
                    creator.ChangeState(new UIPlayerTurn(EnemyBuilder.GetProduct(), Hero, new List<string>()));
                    Console.Clear();
                break;
                case 4:
                    creator.ChangeState(new UIMenu());
                    Console.Clear();
                break;
            }
            
        }
    }
}