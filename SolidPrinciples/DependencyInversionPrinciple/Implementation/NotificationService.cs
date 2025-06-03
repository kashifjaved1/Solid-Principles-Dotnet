using System;
using SolidPrinciples.DependencyInversionPrinciple.Interfaces;

namespace SolidPrinciples.DependencyInversionPrinciple.Implementation
{
    // High-level module: NotificationService depends on the IMessageSender abstraction,
    // not on concrete EmailSender or SMSSender.
    public class NotificationService
    {
        private readonly IMessageSender _messageSender;

        // Dependency is injected via constructor
        public NotificationService(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public void NotifyUser(string user, string notificationMessage)
        {
            _messageSender.SendMessage(user, notificationMessage);
        }
    }
}