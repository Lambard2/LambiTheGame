using System.Threading;
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
    public class UIPlayerTurn : UIState
    {
        public UIPlayerTurn(IEntity enemy, IEntity hero, List<string> log)
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
        if(enemy.Health <=0)
        {
            Console.Clear();
            Console.WriteLine("You win");
            Console.ReadKey();
            creator.ChangeState(new UIMenu());
            return;
        }
        else if(hero.Health <=0)
        {
            Console.Clear();
            Console.WriteLine("You lose");
            Console.ReadKey();
            creator.ChangeState(new UIMenu());
            return;
        }
        UIFightStats.RenderStats(1,10,enemy,hero);
        choice = UISkeleton.Choice(1, 10, "Attack", "Defend","Use Spell","Save Game","To menu");
            switch(choice)
            {
                case 0:
                    hero.AttackMove(enemy);
                    log.Add($"{DateTime.Now.ToString("h:mm:ss tt")} You dealt {hero.Attack-enemy.Defense} damage");
                    UIFightStats.RenderLogs(1,10,enemy,hero,log);
                    UIFightStats.RenderStats(1,10,enemy,hero);
                    Console.Clear();
                    creator.ChangeState(new UIEnemyTurn(enemy, hero, log));
                break;
                case 1:
                    hero.Defense+=5;
                    log.Add($"{DateTime.Now.ToString("h:mm:ss tt")} Your defense has increased by 5 points");
                    UIFightStats.RenderLogs(1,10,enemy,hero,log);
                    UIFightStats.RenderStats(1,10,enemy,hero);
                    Console.Clear();
                    creator.ChangeState(new UIEnemyTurn(enemy, hero, log));
                break;
                case 2:
                    hero.UseAbility(enemy);
                    log.Add($"{DateTime.Now.ToString("h:mm:ss tt")} Your ability caused effect for {hero.MagicPower} power");
                    UIFightStats.RenderLogs(1,10,enemy,hero,log);
                    UIFightStats.RenderStats(1,10,enemy,hero);
                    Console.Clear();
                    creator.ChangeState(new UIEnemyTurn(enemy, hero, log));
                break;
                case 3:
                    Console.Clear();
                    creator.ChangeState(new UISaveMenu(enemy, hero, log));
                break;
                case 4:
                    creator.ChangeState(new UIMenu());
                break;
            }
        }
    }
}