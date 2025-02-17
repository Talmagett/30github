using System;

namespace GamedevClub.TeacherPlans.Encapsulation
{
    public class Lesson10
    {
        public void EncapsulationExample()
        {
            BankAccount account = new BankAccount("Alice", 100);
            account.Deposit(50);
            account.Withdraw(30);
            account.Withdraw(200);
        }
    }

    public class BankAccount
    {
        private string ownerName;
        private double balance;

        public BankAccount(string ownerName, double initialBalance)
        {
            this.ownerName = ownerName;
            balance = initialBalance;
        }

        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value >= 0)
                    balance = value;
                else
                    Console.WriteLine("Balance cannot be negative.");
            }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount}. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew: {amount}. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }
    }
}