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
    public class UIClassSelect : UIState
    {
        public UIClassSelect(){
            HeroBuilderDirector = new(HeroBuilder);
        }
        int choice;
        public HeroBuilder HeroBuilder = new();
        public HeroBuilderDirector HeroBuilderDirector;

        public override void RenderUI(UICreator creator)
        {
            Console.Clear();
            choice = UISkeleton.Choice(1,10,"Barbarian","Sorcerer","Healer");
            switch(choice)
            {
                case 0:
                    HeroBuilderDirector.BuildBarbarian();
                    creator.ChangeState(new UIDiffSelect(HeroBuilder.GetProduct()));
                    Console.Clear();
                break;
                case 1:
                    HeroBuilderDirector.BuildSorcerer();
                    creator.ChangeState(new UIDiffSelect(HeroBuilder.GetProduct()));
                    Console.Clear();
                break;
                case 2:
                    HeroBuilderDirector.BuildHealer();
                    creator.ChangeState(new UIDiffSelect(HeroBuilder.GetProduct()));
                    Console.Clear();
                break;
            }   
        }
    }
}