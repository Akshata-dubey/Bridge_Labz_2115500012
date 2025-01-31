using System;

class EmployeeBonus
{
    static void Main()
    {
        // Prompt the user to enter their salary
        Console.Write("Enter the salary: ");
        double salary = double.Parse(Console.ReadLine());

        // Prompt the user to enter their years of service
        Console.Write("Enter years of service: ");
        int yearsOfService = int.Parse(Console.ReadLine());

        // Check if the years of service are more than 5
        if (yearsOfService > 5)
        {
            // Calculate the bonus (5% of salary)
            double bonus = salary * 0.05;

            // Print the bonus amount
            Console.WriteLine("Bonus amount: " + bonus);
        }
        else
        {
            // No bonus for employees with 5 or fewer years of service
            Console.WriteLine("No bonus as the years of service are less than or equal to 5.");
        }
    }
}
