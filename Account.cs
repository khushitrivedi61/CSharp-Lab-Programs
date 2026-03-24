// Create a class that contains instance variables such as balance and accNo. Derive two classes from it named Savings and Current.
// Define appropriate methods in all classes to perform operations like deposit and withdraw for both Savings and Current accounts.
// Use the concept of inheritance and implement method overriding where required.

using System;

class Account
{
    public int accNo;
    public double balance;

    public virtual void Deposit(double amount)
    {
        balance += amount;
    }

    public virtual void Withdraw(double amount)
    {
        balance -= amount;
    }
}

class Savings : Account
{
    public override void Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }
}

class Current : Account
{
    public override void Withdraw(double amount)
    {
        balance -= amount;
    }
}

class Program
{
    static void Main()
    {
        Savings s = new Savings();
        s.accNo = 1;
        s.balance = 1000;
        s.Deposit(500);
        s.Withdraw(300);
        Console.WriteLine(s.balance);

        Current c = new Current();
        c.accNo = 2;
        c.balance = 2000;
        c.Deposit(1000);
        c.Withdraw(3500);
        Console.WriteLine(c.balance);
    }
}