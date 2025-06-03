using System;
using System.Collections.Generic;
using SolidPrinciples.OpenClosedPrinciple.Interfaces;

namespace SolidPrinciples.OpenClosedPrinciple.Implementation
{
    // New shape: Triangle (extending the system without modifying AreaCalculator)
    public class Triangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }
}