using System;
using System.Collections.Generic;
using SolidPrinciples.OpenClosedPrinciple.Interfaces;

namespace SolidPrinciples.OpenClosedPrinciple.Implementation
{
    // Concrete shape: Circle
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}