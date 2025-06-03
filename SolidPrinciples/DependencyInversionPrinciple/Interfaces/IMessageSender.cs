using System;

namespace SolidPrinciples.DependencyInversionPrinciple.Interfaces
{
    // Abstraction: Interface for sending messages
    public interface IMessageSender
    {
        void SendMessage(string recipient, string message);
    }
}