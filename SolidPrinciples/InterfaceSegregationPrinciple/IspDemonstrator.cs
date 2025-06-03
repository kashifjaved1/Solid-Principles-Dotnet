using System;
using SolidPrinciples.InterfaceSegregationPrinciple.Implementation;

namespace SolidPrinciples.InterfaceSegregationPrinciple
{
    public class IspDemonstrator
    {
        public static void Demonstrate()
        {
            Console.WriteLine("--- Interface Segregation Principle (ISP) ---");

            var simplePrinter = new SimplePrinter();
            var printerScanner = new PrinterWithScanner();
            var mfp = new MultiFunctionPrinter();

            Console.WriteLine("Using SimplePrinter (only needs IPrinter):");
            PrintClient pc1 = new PrintClient(simplePrinter);
            pc1.DoPrintJob("MyTextFile.txt");

            Console.WriteLine("\nUsing PrinterWithScanner (PrintClient still only cares about IPrinter):");
            PrintClient pc2 = new PrintClient(printerScanner);
            pc2.DoPrintJob("MyDocument.docx");
            // If we need to scan with printerScanner:
            // IScanner scanner = printerScanner; // Explicitly get the IScanner interface
            // scanner.Scan("MyPhoto.jpg"); 
            printerScanner.Scan("MyPhoto.jpg"); // or call directly


            Console.WriteLine("\nUsing MultiFunctionPrinter:");
            mfp.Print("Report.pdf");
            mfp.Scan("Invoice.png");
            mfp.Fax("Contract.doc");

            Console.WriteLine("\nISP: Clients (like PrintClient) are not forced to depend on methods they do not use.");
            Console.WriteLine("SimplePrinter only implements IPrinter. PrinterWithScanner implements IPrinter and IScanner.");
            Console.WriteLine("This avoids 'fat' interfaces and promotes better design.");
            Console.WriteLine();
        }
    }
}