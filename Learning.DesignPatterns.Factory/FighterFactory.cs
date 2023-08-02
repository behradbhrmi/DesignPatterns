using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPatterns.Factory
{
    public static class FighterFactory
    {
        public static Fighter? Create(string fighterType)
        {
            if (fighterType == "rifle")
                return new GunFighter();
            else if (fighterType == "bazooka")
                return new BazookaFighter();
            return null;
        }
    }
}
