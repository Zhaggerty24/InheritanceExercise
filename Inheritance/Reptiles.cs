using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public bool HasVibraniumScales { get; set; }
        public bool HasSuperStrength { get; set; } = true;
        public string Defense { get; set; }
        public string Environment { get; set; }


        public Reptile()
        {

        }

        public Reptile(int legs, int age, string name, bool predator, bool hasVibraniumScales, bool hasSuperStrength, string defense, string environment)
        {
            Legs = legs;
            Age = age;
            Name = name;
            Predator = predator;
            HasVibraniumScales = hasVibraniumScales;
            HasSuperStrength = hasSuperStrength;
            Defense = defense;
            Environment = environment;
        }
    }
}
