using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPatterns.Factory
{
    public class Gun
    {
        private readonly IRandomizer _randomizer;

        public string? Type { get; set; }
        public int Damage { get; set; }
        public Gun(string gunType, IRandomizer randomizer)
        {
            Type = gunType;
            this._randomizer = randomizer;
            switch (gunType)
            {
                case "rifle":
                    Damage = 30;
                    break;
                case "pistol":
                    Damage = 8;
                    break;
                case "machine gun":
                    Damage = 39;
                    break;
                case "bazooka":
                    Damage = 500;
                    break;
            }
        }
        public void Fire(Enemy enemy)
        {
            if(enemy == null)
            {
                Console.WriteLine(" > enemy not found!");
                return;
            }
            Console.WriteLine($" > {Type} fired at enemy.");
            if (enemy.IsDead)
            {
                Console.WriteLine($" > enemy is already dead! you can stop shooting!");
                return;
            }
            //simulating taret hit
            enemy.IsHit = _randomizer.RandomizedBoolean(5);//Randomizer.RandomizedBoolean(5);
            if (enemy.IsHit)
            {
                Console.WriteLine($" > target hit with damage of {Damage}");
                enemy.Health -= Damage;
                if (enemy.Health <= 0)
                {
                    Console.WriteLine(" > enemy is down!");
                    enemy.IsDead = true;
                }
                Console.WriteLine($" > enemy's health is {enemy.Health}");
            }
            else
                Console.WriteLine(" > you missed the target!");
        }

    }
}
