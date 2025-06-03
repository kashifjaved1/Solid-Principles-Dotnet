using System;

namespace SolidPrinciples.LiskovSubstitutionPrinciple.Abstraction
{
    // Base class
    public abstract class Bird
    {
        public string Name { get; set; }
        public Bird(string name) { Name = name; }

        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }
}