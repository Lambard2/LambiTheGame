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
    public class UILoadMenu : UIState
    {
        int choice;
        public override void RenderUI(UICreator creator)
        {
            choice = UISkeleton.Choice(1, 10, "Load from TXT", "Load from DB");
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