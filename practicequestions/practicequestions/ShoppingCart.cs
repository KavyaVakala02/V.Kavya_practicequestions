using System;

namespace practicequestions
{
    class ShoppingCart
    {
        private IDiscountStrategy _discountStrategy;
        public double TotalAmount { get; set; }

        public ShoppingCart(double totalAmount)
        {
            TotalAmount = totalAmount;
            _discountStrategy = new NoDiscount(); // Default strategy
        }

        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public void ApplyDiscount()
        {
            double finalAmount = _discountStrategy.ApplyDiscount(TotalAmount);
            Console.WriteLine($"Final Amount after discount: ${finalAmount}");
        }
    }
}
