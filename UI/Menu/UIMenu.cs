using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Game.UI.State;

namespace Game.UI.Menu
{
    public class UIMenu : UIState
    {
        int choice;
        public override void RenderUI(UICreator creator)
        {
            Console.Clear();
            choice = UISkeleton.Choice(1, 10, "Start","Load Game","Exit");
            switch(choice)
            {
                case 0:
                    creator.ChangeState(new UIClassSelect());
                break;
                case 1:
                    throw new NotImplementedException();
                case 2: case -1:
                    Environment.Exit(0);
                break;
            }
            
        }
    }
}