using System;
using SolidPrinciples.LiskovSubstitutionPrinciple.Abstraction;

namespace SolidPrinciples.LiskovSubstitutionPrinciple.Implementation
{
    // Subclass that can fly
    public class FlyingBird : Bird
    {
        public FlyingBird(string name) : base(name) { }

        public virtual void Fly()
        {
            Console.WriteLine($"{Name} is flying.");
        }
    }
}