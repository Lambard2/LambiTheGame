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
    public class UIEnemyTurn : UIState
    {
        public UIEnemyTurn(IEntity enemy,IEntity hero, List<string> log){
            this.enemy = enemy;
            this.hero = hero;
            this.log = log;
        }
        IEntity enemy;
        IEntity hero;
        List<String> log;
        public override void RenderUI(UICreator creator)
        {
        if(enemy.Health <=0)
        {
            Console.Clear();
            Console.WriteLine("\nYou win");
            Console.ReadKey();
            creator.ChangeState(new UIMenu());
            return;
        }
        else if(hero.Health <=0)
        {
            Console.Clear();
            Console.WriteLine("\nYou lose");
            Console.ReadKey();
            creator.ChangeState(new UIMenu());
            return;
        }
            enemy.AttackMove(hero);
            Console.ForegroundColor = ConsoleColor.Red;
            if(hero.Defense >= enemy.Attack)
            {
                log.Add($"{DateTime.Now.ToString("h:mm:ss tt")} Enemy has dealt 1 damage");
            }
            else
            {
            log.Add($"{DateTime.Now.ToString("h:mm:ss tt")} Enemy has dealt {enemy.Attack-hero.Defense} damage");
            }
            UIFightStats.RenderLogs(1,10,enemy,hero,log);
            UIFightStats.RenderStats(1,10,enemy,hero);
            creator.ChangeState(new UIPlayerTurn(enemy, hero, log));
        }
    }
}