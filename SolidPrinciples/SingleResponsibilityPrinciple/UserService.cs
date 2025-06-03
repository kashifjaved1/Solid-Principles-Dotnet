using System;

namespace SolidPrinciples.SingleResponsibilityPrinciple
{
    // Good example: Separating responsibilities

    // Responsibility 1: User data management
    public class UserService
    {
        public void RegisterUser(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Username and password cannot be empty.");
            }
            Console.WriteLine($"User {username} registered using UserService.");
            // Further logic for saving user to database, etc.
        }
    }
}
