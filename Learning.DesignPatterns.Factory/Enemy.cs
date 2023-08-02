using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPatterns.Factory
{
    public class Enemy
    {
        public string Name { get; set; } = "enemy";
        public int Level { get; set; }
        public bool IsHit { get; set; }
        public int Health { get; set; }
        public bool IsDead { get; set; }
        public Enemy(int level)
        {
            if (level == 0)
                Health = 100;
            else if (level == 1)
                Health = 150;
            else if (level == 2)
                Health = 200;
            else if (level == 3)
                Health = 600;
        }
    }
}
