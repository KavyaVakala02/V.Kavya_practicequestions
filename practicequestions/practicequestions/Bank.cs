using System;

namespace practicequestions
{
    class Bank
    {
        public string AccountHolder { get; set; }
        public double Balance { get; set; }
        public static double InterestRate { get; private set; } = 5.0; // Default interest rate

        public Bank(string accountHolder, double balance)
        {
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public static void SetInterestRate(double newRate)
        {
            InterestRate = newRate;
            Console.WriteLine($"Interest Rate updated to: {InterestRate}%");
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Holder: {AccountHolder}, Balance: ${Balance}, Interest Rate: {InterestRate}%");
        }
    }
}
