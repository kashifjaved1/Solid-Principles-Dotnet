using System;
using SolidPrinciples.LiskovSubstitutionPrinciple.Abstraction;
using SolidPrinciples.LiskovSubstitutionPrinciple.Implementation;

namespace SolidPrinciples.LiskovSubstitutionPrinciple
{
    public class LspDemonstrator
    {
        public static void MakeBirdEat(Bird bird)
        {
            bird.Eat(); // This works for any bird
        }

        public static void MakeFlyingBirdFly(FlyingBird flyingBird)
        {
            flyingBird.Fly(); // This only works for birds that can fly
        }

        public static void Demonstrate()
        {
            Console.WriteLine("--- Liskov Substitution Principle (LSP) ---");

            Bird sparrowAsBird = new Sparrow("Sparry the Sparrow");
            FlyingBird sparrowAsFlyingBird = new Sparrow("Sparry the Sparrow");
            Bird ostrich = new Ostrich("Ozzy the Ostrich");

            Console.WriteLine("Demonstrating Eat (works for all birds):");
            MakeBirdEat(sparrowAsBird);
            MakeBirdEat(ostrich);

            Console.WriteLine("\nDemonstrating Fly (works for FlyingBirds):");
            MakeFlyingBirdFly(sparrowAsFlyingBird);
            // MakeFlyingBirdFly(ostrich); // This would be a compile-time error, which is good.
            // If Ostrich inherited Fly() and threw NotImplementedException,
            // it would be a runtime violation of LSP.

            if (ostrich is Ostrich ozzy)
            {
                ozzy.Run();
            }

            Console.WriteLine("\nLSP: Subtypes (Sparrow, Ostrich) can be substituted for their base types (Bird/FlyingBird) without altering the program's correctness.");
            Console.WriteLine("Crucially, methods expecting a FlyingBird get a bird that can fly. Ostrich is not a FlyingBird.");
            Console.WriteLine("If Bird had a Fly() method, Ostrich would either have to implement it (incorrectly) or throw an exception (violating LSP at runtime).");
            Console.WriteLine();
        }
    }
}