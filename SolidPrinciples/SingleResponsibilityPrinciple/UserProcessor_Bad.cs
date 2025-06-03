using System;

namespace SolidPrinciples.SingleResponsibilityPrinciple
{
    // Bad example: A class with multiple responsibilities
    public class UserProcessor_Bad
    {
        public void RegisterUser(string username, string password)
        {
            // Responsibility 1: User registration logic
            Console.WriteLine($"User {username} registered.");
            // Responsibility 2: Sending notification
            SendConfirmationEmail(username);
        }

        public void SendConfirmationEmail(string username)
        {
            Console.WriteLine($"Email sent to {username}.");
        }
    }
}
