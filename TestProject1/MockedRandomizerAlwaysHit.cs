using Learning.DesignPatterns.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class MockedRandomizerAlwaysHit : IRandomizer
    {
        public bool RandomizedBoolean(int trueChance)
        {
            return true;
        }
    }
}
