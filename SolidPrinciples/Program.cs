using SolidPrinciples.DependencyInversionPrinciple;
using SolidPrinciples.InterfaceSegregationPrinciple;
using SolidPrinciples.LiskovSubstitutionPrinciple;
using SolidPrinciples.OpenClosedPrinciple;
using SolidPrinciples.SingleResponsibilityPrinciple;

namespace SolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the SOLID Principles Demonstration!\n");

            // Demonstrate Single Responsibility Principle
            SrpDemonstrator.Demonstrate();

            // Demonstrate Open/Closed Principle
            OcpDemonstrator.Demonstrate();

            // Demonstrate Liskov Substitution Principle
            LspDemonstrator.Demonstrate();

            // Demonstrate Interface Segregation Principle
            IspDemonstrator.Demonstrate();

            // Demonstrate Dependency Inversion Principle
            DipDemonstrator.Demonstrate();

            Console.WriteLine("SOLID Principles demonstration finished. Press any key to exit.");

            Console.ReadKey();
        }
    }
}