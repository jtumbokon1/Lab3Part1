using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Part1
{
    public abstract class Animal
    {
        // public properties
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Age { get; set; }

        // constructor
        public Animal(string name, string colour, int age)
        {
            this.Age = age;
            this.Colour = colour;
            this.Name = name;
        }

        // public methods
        public abstract void Eat();
        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"Colour: {Colour}\n" +
                   $"Age: {Age}";
        }
    } // class
} // namespace
