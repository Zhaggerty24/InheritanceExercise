using System;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Bird areon = new Bird()
            {
                Name = "Areon",
                Predator = true,
                Age = 658,
                Wings = 2,
                Legs = 2,
                HasElectricAura = true,
                ElectricityImmune = true,
                Type = "Electric",

            };
            
             
            Console.WriteLine($" {areon.Name} is an {areon.Type} super pet that is {areon.Age} years old and has " +
                $"{areon.Legs} legs and {areon.Wings} electric wings.");
            Console.WriteLine($"{areon.Name} is enhanced with an electric aura, is immune to electricity and is a predator." +
                $"{areon.HasElectricAura}, {areon.ElectricityImmune}, and {areon.Predator}.");
            Console.WriteLine();

            Reptile mushu = new Reptile()
            {
                Name = "Mushu",
                Age = 1562,
                Legs = 2,
                Predator = true,
                HasVibraniumScales = true,
                HasSuperStrength = true,
                Defense = "Water Blast",
                Environment = "Water",

            };


            Console.WriteLine($" {mushu.Name} is a super lizzard that is {mushu.Age} years old and lives under {mushu.Environment}," +
                $"can hit you with a {mushu.Defense} and has {mushu.Legs} legs and arms.");
            Console.WriteLine($" {mushu.Name} is enhanced with Vibranium scales, has super strength and is a predator. " +
                $"{mushu.HasVibraniumScales}, {mushu.HasSuperStrength}, and {mushu.Predator}");
            Console.WriteLine();


            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
