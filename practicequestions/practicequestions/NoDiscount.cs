using System;

namespace practicequestions
{
    class NoDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(double totalAmount)
        {
            return totalAmount; // No discount applied
        }
    }
}
