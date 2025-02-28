using System;

namespace practicequestions
{
    class PercentageDiscount : IDiscountStrategy
    {
        private readonly double _percentage;

        public PercentageDiscount(double percentage)
        {
            _percentage = percentage;
        }

        public double ApplyDiscount(double totalAmount)
        {
            return totalAmount - (totalAmount * _percentage / 100);
        }
    }
}
