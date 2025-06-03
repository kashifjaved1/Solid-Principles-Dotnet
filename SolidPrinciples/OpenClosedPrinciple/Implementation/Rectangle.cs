using System;
using System.Collections.Generic;
using SolidPrinciples.OpenClosedPrinciple.Interfaces;

namespace SolidPrinciples.OpenClosedPrinciple.Implementation
{
    // Concrete shape: Rectangle
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }
}