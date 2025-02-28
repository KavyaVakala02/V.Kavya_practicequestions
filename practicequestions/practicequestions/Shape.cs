using System;

namespace practicequestions
{
    abstract class Shape
    {
        // Abstract method to be implemented in derived classes
        public abstract double CalculateArea();

        // Common method for all shapes
        public void DisplayArea()
        {
            Console.WriteLine($"Area: {CalculateArea()}");
        }
    }
}
