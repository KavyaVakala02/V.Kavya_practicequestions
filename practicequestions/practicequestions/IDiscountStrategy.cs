using System;

namespace practicequestions
{
    interface IDiscountStrategy
    {
        double ApplyDiscount(double totalAmount);
    }
}
