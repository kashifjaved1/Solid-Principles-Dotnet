using System;
using System.Collections.Generic;
using SolidPrinciples.OpenClosedPrinciple.Interfaces;

namespace SolidPrinciples.OpenClosedPrinciple.Implementation
{
    // This class is closed for modification but open for extension (by adding new IShape implementations)
    public class AreaCalculator
    {
        public double CalculateTotalArea(List<IShape> shapes)
        {
            double totalArea = 0;
            foreach (var shape in shapes)
            {
                totalArea += shape.CalculateArea(); // No modification needed here for new shapes
            }
            return totalArea;
        }
    }
}