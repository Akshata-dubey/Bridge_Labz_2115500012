using System;

class BankAccount
{
    // Public field: Account Number
    public int AccountNumber { get; set; }

    // Protected field: Account Holder (accessible in subclasses)
    protected string AccountHolder { get; set; }

    // Private field: Balance (cannot be accessed directly outside the class)
    private double Balance;

    // Constructor to initialize account details
    public BankAccount(int accountNumber, string accountHolder)
    {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
    }

    // Method to set balance
    public void SetBalance(double amount)
    {
        if (amount >= 0)
        {
            Balance = amount;
        }
        else
        {
            Console.WriteLine("Balance cannot be negative.");
        }
    }

    // Method to get balance
    public double GetBalance()
    {
        return Balance;
    }
}

class SavingsAccount : BankAccount
{
    // Constructor to initialize savings account details
    public SavingsAccount(int accountNumber, string accountHolder)
        : base(accountNumber, accountHolder)
    {
    }

    // Method to display account details (account number and holder)
    public void DisplayAccountDetails()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Account Holder: {AccountHolder}");
    }

    // Method to deposit money into the savings account
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            SetBalance(GetBalance() + amount);
            Console.WriteLine($"Deposited: {amount}. New Balance: {GetBalance()}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    // Method to withdraw money from the savings account
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= GetBalance())
        {
            SetBalance(GetBalance() - amount);
            Console.WriteLine($"Withdrew: {amount}. Remaining Balance: {GetBalance()}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }
}

class BankAccountManagement
{
    // Main entry point of the program
    // static void Main()
    // {
        // // Create a new SavingsAccount instance with account details
        // SavingsAccount savingsAccount = new SavingsAccount(123456, "John Doe");

        // // Set the initial balance
        // savingsAccount.SetBalance(1000);

        // // Display account details
        // savingsAccount.DisplayAccountDetails();

        // // Perform some transactions
        // savingsAccount.Deposit(500);
        // savingsAccount.Withdraw(200);
        // savingsAccount.Withdraw(1500); // Invalid withdrawal attempt

        // // Display account details after transactions
        // savingsAccount.DisplayAccountDetails();
    // }
}
