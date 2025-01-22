using System;

class IncomeCalculator
{
    static void Main()
    {
        // Input: Ask the user to enter the salary
        Console.Write("Enter the salary (INR): ");
        double salary = Convert.ToDouble(Console.ReadLine());

        // Input: Ask the user to enter the bonus
        Console.Write("Enter the bonus (INR): ");
        double bonus = Convert.ToDouble(Console.ReadLine());

        // Calculate the total income
        double totalIncome = salary + bonus;

        // Output the result
        Console.WriteLine("The salary is INR " + salary + " and bonus is INR " + bonus + ". Hence Total Income is INR " + totalIncome + ".");
    }
}
