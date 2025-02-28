using System;

namespace practicequestions
{
    class FixedAmountDiscount : IDiscountStrategy
    {
        private readonly double _discountAmount;

        public FixedAmountDiscount(double discountAmount)
        {
            _discountAmount = discountAmount;
        }

        public double ApplyDiscount(double totalAmount)
        {
            return Math.Max(totalAmount - _discountAmount, 0);
        }
    }
}
