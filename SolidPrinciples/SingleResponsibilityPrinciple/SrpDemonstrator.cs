using System;

namespace SolidPrinciples.SingleResponsibilityPrinciple
{
    public class SrpDemonstrator
    {
        public static void Demonstrate()
        {
            Console.WriteLine("--- Single Responsibility Principle (SRP) ---");

            // Using the good example
            var userService = new UserService();
            var notificationService = new NotificationService();

            string user = "john.doe";
            userService.RegisterUser(user, "password123");
            notificationService.SendConfirmationEmail(user);

            Console.WriteLine("\nSRP: Each class (UserService, NotificationService) has a single responsibility.\n");
        }
    }
}
