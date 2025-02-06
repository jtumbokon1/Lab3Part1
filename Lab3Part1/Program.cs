/*
 * CPRG-211-C Lab Interfaces and Abstract Classes
 * Author: Jirch Tumbokon
 * When: Winter 2025
 */

/*
 * This program demonstrates the use of interfaces and abstract classes
 * by creating a Dog and Cat class that inherit from an abstract Animal class
 * It displays the name, colour, age of the animal and what they eat
 */

using Lab3Part1;

class Program
{
    static void Main()
    {
        Dog dog = new Dog("Rover", "Brown", 5); // create a Dog object
        Console.WriteLine(dog);
        dog.Eat();

        Console.WriteLine(); // empty line

        Cat cat = new Cat("Whiskers", "White", 3); // create a Cat object
        Console.WriteLine(cat);
        cat.Eat();
    }
}
