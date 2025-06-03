using System;
using SolidPrinciples.LiskovSubstitutionPrinciple.Abstraction;

namespace SolidPrinciples.LiskovSubstitutionPrinciple.Implementation
{
    // Subclass: Ostrich cannot fly. If Ostrich inherited from a Bird class that had a Fly() method,
    // it might violate LSP if Fly() was expected to always work.
    // By having a separate FlyingBird, we make the hierarchy more compliant.
    public class Ostrich : Bird // Ostrich inherits from Bird, not FlyingBird
    {
        public Ostrich(string name) : base(name) { }

        // Ostrich doesn't have a Fly() method here, which is good for LSP
        // if the client code specifically expects a FlyingBird to fly.
        public void Run()
        {
            Console.WriteLine($"{Name} is running fast!");
        }
    }
}