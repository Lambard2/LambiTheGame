using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Game.UI.Menu;

namespace Game.UI.State
{
    public class UICreator
    {
        UIState state;
        public UICreator()
        {
            this.state = new UIMenu();
        }
        public void ChangeState(UIState state)
        {
            this.state = state;
        }
        public void RenderUI()
        {
            state.RenderUI(this);       
        }
    }
}