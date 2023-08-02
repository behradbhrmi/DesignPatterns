using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPatterns.Factory
{
    public abstract class Fighter
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Score { get; set; }
        public string GunType { get; set; }
        public Gun Gun { get; set; }

        public virtual void Fight(Enemy enemy) { }
    }
}
