using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPatterns.Factory
{
    public class GamePlay
    {
        public void StartGame(Fighter fighter, Enemy enemy)
        {
            fighter.Fight(enemy);
        }
    }
}
