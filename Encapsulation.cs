using System;

class BankAccount
{
    // Private field (hidden data)
    private double balance;

    // Public method to set value (controlled access)
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    // Public method to get value (controlled access)
    public double GetBalance()
    {
        return balance;
    }
}

class Encapsulation
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();

        account.Deposit(1000);

        Console.WriteLine("Balance: " + account.GetBalance());
    }
}
