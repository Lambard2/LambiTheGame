using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game.UI.State
{
    public abstract class UIState
    {
        public abstract void RenderUI(UICreator creator);
    }
}