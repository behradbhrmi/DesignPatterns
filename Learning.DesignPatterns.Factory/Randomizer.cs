using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPatterns.Factory
{
    public class Randomizer : IRandomizer
    {
        public bool RandomizedBoolean(int trueChance)
        {
            var random = new Random().Next(1, 10);
            if(random > 10 - trueChance)
            {
                return true;
            }
            return false;
        }
    }
}
