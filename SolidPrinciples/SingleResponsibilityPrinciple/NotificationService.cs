using System;

namespace SolidPrinciples.SingleResponsibilityPrinciple
{
    // Responsibility 2: Notification management
    public class NotificationService
    {
        public void SendConfirmationEmail(string username)
        {
            Console.WriteLine($"Confirmation email sent to {username} via NotificationService.");
        }
    }
}
