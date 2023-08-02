using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPatterns.Factory
{
    public interface IRandomizer
    {
        public bool RandomizedBoolean(int trueChance);
    }
}
