using System;
using SolidPrinciples.InterfaceSegregationPrinciple.Interfaces;

namespace SolidPrinciples.InterfaceSegregationPrinciple.Implementation
{
    // Class implementing IPrinter and IScanner (e.g., a printer with scanner)
    public class PrinterWithScanner : IPrinter, IScanner
    {
        public void Print(string document)
        {
            Console.WriteLine($"PrinterWithScanner: Printing {document}");
        }

        public void Scan(string document)
        {
            Console.WriteLine($"PrinterWithScanner: Scanning {document}");
        }
    }
}