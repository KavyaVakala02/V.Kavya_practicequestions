using System;
using System.Collections.Generic;

namespace practicequestions
{
    class NotificationSubject
    {
        private readonly List<INotificationObserver> _observers = new List<INotificationObserver>();

        // Add an observer
        public void Attach(INotificationObserver observer)
        {
            _observers.Add(observer);
        }

        // Remove an observer
        public void Detach(INotificationObserver observer)
        {
            _observers.Remove(observer);
        }

        // Notify all observers
        public void Notify(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }
    }
}
