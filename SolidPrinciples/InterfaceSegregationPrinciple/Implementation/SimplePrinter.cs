using System;
using SolidPrinciples.InterfaceSegregationPrinciple.Interfaces;

namespace SolidPrinciples.InterfaceSegregationPrinciple.Implementation
{
    // Class implementing only IPrinter (e.g., a simple printer)
    public class SimplePrinter : IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine($"SimplePrinter: Printing {document}");
        }
    }
}