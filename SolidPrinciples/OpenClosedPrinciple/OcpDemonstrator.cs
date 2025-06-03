using SolidPrinciples.OpenClosedPrinciple.Implementation;
using SolidPrinciples.OpenClosedPrinciple.Interfaces;

namespace SolidPrinciples.OpenClosedPrinciple
{
    public class OcpDemonstrator
    {
        public static void Demonstrate()
        {
            Console.WriteLine("--- Open/Closed Principle (OCP) ---");

            var shapes = new List<IShape>
            {
                new Rectangle { Width = 10, Height = 5 },
                new Circle { Radius = 7 },
                new Triangle { Base = 4, Height = 3 } // New shape added easily
            };

            var calculator = new AreaCalculator();
            double totalArea = calculator.CalculateTotalArea(shapes);

            Console.WriteLine($"Total area of all shapes: {totalArea}");
            Console.WriteLine("\nOCP: The AreaCalculator can work with new shapes (e.g., Triangle) without any changes to its own code.\n");
        }
    }
}