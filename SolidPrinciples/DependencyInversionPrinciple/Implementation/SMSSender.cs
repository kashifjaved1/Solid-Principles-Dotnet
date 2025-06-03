using System;
using SolidPrinciples.DependencyInversionPrinciple.Interfaces;

namespace SolidPrinciples.DependencyInversionPrinciple.Implementation
{
    // Low-level module: SMSSender implements the abstraction
    public class SMSSender : IMessageSender
    {
        public void SendMessage(string recipient, string message)
        {
            Console.WriteLine($"SMS sent to {recipient}: {message}");
        }
    }
}