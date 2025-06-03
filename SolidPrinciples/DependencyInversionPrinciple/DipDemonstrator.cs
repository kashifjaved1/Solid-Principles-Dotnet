using System;
using SolidPrinciples.DependencyInversionPrinciple.Implementation;
using SolidPrinciples.DependencyInversionPrinciple.Interfaces;

namespace SolidPrinciples.DependencyInversionPrinciple
{
    public class DipDemonstrator
    {
        public static void Demonstrate()
        {
            Console.WriteLine("--- Dependency Inversion Principle (DIP) ---");

            // Create concrete sender (low-level module)
            IMessageSender emailSender = new EmailSender();
            IMessageSender smsSender = new SMSSender();

            // Inject dependency into high-level module
            Console.WriteLine("Using EmailSender:");
            NotificationService emailNotificationService = new NotificationService(emailSender);
            emailNotificationService.NotifyUser("john.doe@example.com", "Your order has shipped!");

            Console.WriteLine("\nUsing SMSSender:");
            NotificationService smsNotificationService = new NotificationService(smsSender);
            smsNotificationService.NotifyUser("+1234567890", "Your package is out for delivery.");

            Console.WriteLine("\nDIP: High-level NotificationService depends on the IMessageSender abstraction, not concrete senders.");
            Console.WriteLine("Low-level modules (EmailSender, SMSSender) also depend on this abstraction.");
            Console.WriteLine("This allows for decoupling and easier substitution of components (e.g., switch to a PushNotificationSender).");
            Console.WriteLine();
        }
    }
}