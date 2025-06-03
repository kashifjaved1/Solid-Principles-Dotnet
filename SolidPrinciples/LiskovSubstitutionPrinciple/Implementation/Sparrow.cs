using System;

namespace SolidPrinciples.LiskovSubstitutionPrinciple.Implementation
{
    // Subclass: Sparrow can fly
    public class Sparrow : FlyingBird
    {
        public Sparrow(string name) : base(name) { }
    }
}