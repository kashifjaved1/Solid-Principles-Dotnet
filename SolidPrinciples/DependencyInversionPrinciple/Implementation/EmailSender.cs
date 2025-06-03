using System;
using SolidPrinciples.DependencyInversionPrinciple.Interfaces;

namespace SolidPrinciples.DependencyInversionPrinciple.Implementation
{
    // Low-level module: EmailSender implementsthe abstraction
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string recipient, string message)
        {
            Console.WriteLine($"Email sent to {recipient}: {message}");
        }
    }
}