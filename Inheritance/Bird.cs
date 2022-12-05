using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public int Wings { get; set; }
        public string Type { get; set; }
        public bool HasElectricAura { get; set; } = true;   
        public bool ElectricityImmune { get; set; } = true;

        public Bird()
        {

        }

        public Bird(int wings, int age, int legs, string name, string type, bool hasElectricAura, bool electricityImmune, bool isPredator)
        {
            Predator = isPredator;
            Age = age;
            Wings = wings;
            Legs = legs;
            Name = name;
            HasElectricAura = hasElectricAura;
            ElectricityImmune = electricityImmune;
            Type = type;
        }   
    }
}
