using System;
using SolidPrinciples.InterfaceSegregationPrinciple.Interfaces;

namespace SolidPrinciples.InterfaceSegregationPrinciple.Implementation
{
    // Client code that only needs printing
    public class PrintClient
    {
        private readonly IPrinter _printer;
        public PrintClient(IPrinter printer)
        {
            _printer = printer;
        }
        public void DoPrintJob(string document)
        {
            _printer.Print(document);
        }
    }
}