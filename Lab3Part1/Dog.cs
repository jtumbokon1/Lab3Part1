using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Part1
{
    public class Dog : Animal
    {

        // constructor
        public Dog(string name, string colour, int age) : 
            base(name, colour, age)
        {
        }

        // public methods
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }
    } // class
} // namespace
