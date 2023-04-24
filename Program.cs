using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using System;
using Game.UI.State;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {        
            var UI = new UICreator();
            while(true)
            {
                UI.RenderUI(); 
            }
        }
    }
}
