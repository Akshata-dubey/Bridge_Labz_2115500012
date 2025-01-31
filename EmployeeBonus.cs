using System;

class EmployeeBonus
{
    static void Main()
    {
        const int employeeCount = 10;
        double[] salaries = new double[employeeCount];
        double[] yearsOfService = new double[employeeCount];
        double[] bonuses = new double[employeeCount];
        double[] newSalaries = new double[employeeCount];

        double totalBonus = 0;
        double totalOldSalary = 0;
        double totalNewSalary = 0;

        for (int i = 0; i < employeeCount; i++)
        {
            Console.WriteLine($"Enter details for Employee {i + 1}:");

            // Input salary
            while (true)
            {
                Console.Write("Enter Salary: ");
                if (double.TryParse(Console.ReadLine(), out double salary) && salary > 0)
                {
                    salaries[i] = salary;
                    break;
                }
                Console.WriteLine("Invalid input. Salary must be a positive number. Please try again.");
            }

            // Input years of service
            while (true)
            {
                Console.Write("Enter Years of Service: ");
                if (double.TryParse(Console.ReadLine(), out double years) && years >= 0)
                {
                    yearsOfService[i] = years;
                    break;
                }
                Console.WriteLine("Invalid input. Years of service must be a non-negative number. Please try again.");
            }
        }

        // Calculate bonus and new salary
        for (int i = 0; i < employeeCount; i++)
        {
            double bonusPercentage = yearsOfService[i] > 5 ? 0.05 : 0.02;
            bonuses[i] = salaries[i] * bonusPercentage;
            newSalaries[i] = salaries[i] + bonuses[i];

            totalBonus += bonuses[i];
            totalOldSalary += salaries[i];
            totalNewSalary += newSalaries[i];
        }

        // Display results
        Console.WriteLine("\nEmployee Details with Bonuses:");
        for (int i = 0; i < employeeCount; i++)
        {
            Console.WriteLine($"Employee {i + 1}: Salary = {salaries[i]:C}, Years of Service = {yearsOfService[i]}, Bonus = {bonuses[i]:C}, New Salary = {newSalaries[i]:C}");
        }

        Console.WriteLine($"\nTotal Bonus Payout: {totalBonus:C}");
        Console.WriteLine($"Total Old Salary: {totalOldSalary:C}");
        Console.WriteLine($"Total New Salary: {totalNewSalary:C}");
    }
}
