using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game.UI.State
{
    public class UISkeleton
    {
        public static int Choice(int optionsPerLine, int spacingPerLine, params string[] choices)
        {

            int currentSelection = 0;
            ConsoleKey key;
            do
            {
                for(int i = 0; i < choices.Length; i++)
                {
                    Console.SetCursorPosition((i % optionsPerLine) * spacingPerLine, i / optionsPerLine);
                    if(i == currentSelection)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.Write(choices[i]);
                    Console.ResetColor();

                }
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                    {
                        if (currentSelection % optionsPerLine > 0)
                            currentSelection--;
                        break;
                    }
                    case ConsoleKey.RightArrow:
                    {
                        if (currentSelection % optionsPerLine < optionsPerLine - 1)
                            currentSelection++;
                        break;
                    }
                    case ConsoleKey.UpArrow:
                    {
                        if (currentSelection >= optionsPerLine)
                            currentSelection -= optionsPerLine;
                        break;
                    }
                    case ConsoleKey.DownArrow:
                    {
                        if (currentSelection + optionsPerLine < choices.Length)
                            currentSelection += optionsPerLine;
                        break;
                    }
                    case ConsoleKey.Escape:
                    {
                        return -1;
                    }
                }
            }
            while(key != ConsoleKey.Enter);

        return currentSelection;
        }
    }
}