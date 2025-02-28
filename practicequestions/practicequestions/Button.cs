using System;

namespace practicequestions
{
    class Button
    {
        // Declare a delegate
        public delegate void ClickHandler();

        // Declare an event using the delegate
        public event ClickHandler OnClick;

        // Method to trigger the event
        public void Click()
        {
            Console.WriteLine("Button clicked!");
            OnClick?.Invoke(); // Trigger the event if there are subscribers
        }
    }
}
