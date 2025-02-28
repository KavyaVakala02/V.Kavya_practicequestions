using System;

class Bankaccount
{
    private double balance;

    public Bankaccount(double initialBalance = 0)
    {
        balance = (initialBalance >= 0) ? initialBalance : 0;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: ${amount}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount!");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: ${amount}");
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount!");
        }
    }

    public void DisplayBalance()
    {
        Console.WriteLine($"Current Balance: ${balance}");
    }
}
