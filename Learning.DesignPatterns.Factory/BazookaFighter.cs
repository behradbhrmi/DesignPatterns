using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPatterns.Factory
{
    public class BazookaFighter : Fighter
    {
        public string Name { get; set; } = "bazooka fighter";
        public string Color { get; set; } = "black";
        public int Score { get; set; }
        public string GunType { get; set; } = "bazooka";
        public Gun Gun { get; set; }
        public BazookaFighter()
        {
            Gun = new Gun(GunType, new Randomizer());
        }
        public override void Fight(Enemy enemy)
        {
            Console.WriteLine($" > gun fighter shooting enemy with a {GunType} ...");
            Gun.Fire(enemy);
        }
    }
}
