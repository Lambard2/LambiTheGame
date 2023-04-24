using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Game.UI.State;
using Game.Entities.EnemyBuilder;
using Game.Entities.HeroBuilder;
using Game.Entities.Interfaces;

namespace Game.UI.Menu
{
    public class UISaveMenu : UIState
    {
        public UISaveMenu(IEntity enemy, IEntity hero, List<string> log)
        {
            this.enemy = enemy;
            this.hero = hero;
            this.log = log;
        }
        IEntity enemy;
        IEntity hero;
        int choice;
        List<string> log;

        public override void RenderUI(UICreator creator)
        {
            choice = UISkeleton.Choice(1, 10, "Save to TXT", "Save to DB");
            switch(choice)
            {
                case 0:
                    throw new NotImplementedException();
                case 1:
                    throw new NotImplementedException();
            }
        }
    }
}