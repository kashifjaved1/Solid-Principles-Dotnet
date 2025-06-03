using System;
using SolidPrinciples.InterfaceSegregationPrinciple.Interfaces;

namespace SolidPrinciples.InterfaceSegregationPrinciple.Implementation
{
    // Class implementing all interfaces (e.g., a multifunction printer)
    public class MultiFunctionPrinter : IPrinter, IScanner, IFax
    {
        public void Print(string document)
        {
            Console.WriteLine($"MultiFunctionPrinter: Printing {document}");
        }

        public void Scan(string document)
        {
            Console.WriteLine($"MultiFunctionPrinter: Scanning {document}");
        }

        public void Fax(string document)
        {
            Console.WriteLine($"MultiFunctionPrinter: Faxing {document}");
        }
    }
}