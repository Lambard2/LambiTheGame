using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Game.Entities.EnemyBuilder;
using Game.Entities.HeroBuilder;
using Game.Entities.Interfaces;

namespace Game.UI.State
{
    public class UIFightStats
    {
        public static void RenderLogs(int optionsPerLine, int spacingPerLine, IEntity enemy, IEntity hero, List<string> log)
        {
            for(int i = 0; i<log.Count; i++)
            {
                if(i%2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                    Console.SetCursorPosition(30+(i % optionsPerLine) * spacingPerLine, i%12);
                    Console.Write(log[i]);
                if(log.Count>12){
                    Console.WriteLine("                             \n                            ");
                }

            }
        }
        public static void RenderStats(int optionsPerLine, int spacingPerLine, IEntity enemy, IEntity hero)
        {
            Console.ResetColor();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("                 \n                      \n              \n            \n                 \n");
            Console.WriteLine($"Hero\nHP: {hero.Health}\nAttack: {hero.Attack}\nDefense: {hero.Defense}\nMagic Power: {hero.MagicPower}");
            Console.WriteLine($"\nEnemy\nHP: {enemy.Health}\nAttack: {enemy.Attack}\nDefense: {enemy.Defense}");
        }
    }
}