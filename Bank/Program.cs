using System;

class BankAccount
{
    // Fields
    public string AccountHolder;
    public double Balance;

    // Constructor
    public BankAccount(string name, double balance)
    {
        AccountHolder = name;
        Balance = balance;
    }

    // Deposit method
    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine("Deposited: " + amount);
    }

    // Withdraw method
    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient Balance!");
        }
    }

    // Show balance
    public void ShowBalance()
    {
        Console.WriteLine("Account Holder: " + AccountHolder);
        Console.WriteLine("Balance: " + Balance);
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc = new BankAccount("John", 1000);

        acc.ShowBalance();

        acc.Deposit(500);
        acc.ShowBalance();

        acc.Withdraw(300);
        acc.ShowBalance();

        acc.Withdraw(1500); // invalid case
        acc.ShowBalance();
    }
}