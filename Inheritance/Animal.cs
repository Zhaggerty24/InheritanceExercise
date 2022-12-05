using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public int Legs { get; set; }
        public int Age { get; set; } 
        public string Name{ get; set; }
        public bool Predator { get; set; } = true;
    }
}
