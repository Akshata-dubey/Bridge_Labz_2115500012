using System;

class ZaraBonusProgram
{
    // Method to determine the salary and years of service, and return the data in a 2D array
    public static double[,] DetermineSalaryAndYears(int numEmployees)
    {
        Random rand = new Random();
        double[,] employeeData = new double[numEmployees, 2]; // 2 columns: salary and years of service

        for (int i = 0; i < numEmployees; i++)
        {
            employeeData[i, 0] = rand.Next(10000, 100000); // Random 5-digit salary
            employeeData[i, 1] = rand.Next(1, 31); // Random years of service between 1 and 30
        }

        return employeeData;
    }

    // Method to calculate the new salary and bonus based on the years of service
    public static double[,] CalculateNewSalaryAndBonus(double[,] employeeData, int numEmployees)
    {
        double[,] updatedData = new double[numEmployees, 3]; // 3 columns: old salary, bonus, new salary

        for (int i = 0; i < numEmployees; i++)
        {
            double oldSalary = employeeData[i, 0];
            int yearsOfService = (int)employeeData[i, 1];
            double bonus;

            // Determine bonus based on years of service
            if (yearsOfService > 5)
                bonus = oldSalary * 0.05; // 5% bonus for more than 5 years of service
            else
                bonus = oldSalary * 0.02; // 2% bonus for 5 years or less of service

            // Calculate the new salary
            double newSalary = oldSalary + bonus;

            // Store the data: old salary, bonus, new salary
            updatedData[i, 0] = oldSalary;
            updatedData[i, 1] = bonus;
            updatedData[i, 2] = newSalary;
        }

        return updatedData;
    }

    // Method to calculate the sum of old salaries, new salaries, and total bonuses
    public static void CalculateAndDisplayTotals(double[,] updatedData, int numEmployees)
    {
        double totalOldSalary = 0;
        double totalNewSalary = 0;
        double totalBonus = 0;

        Console.WriteLine("Employee Salary Details:");
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("Old Salary | Bonus Amount | New Salary");
        Console.WriteLine("---------------------------------------------------------");

        for (int i = 0; i < numEmployees; i++)
        {
            double oldSalary = updatedData[i, 0];
            double bonus = updatedData[i, 1];
            double newSalary = updatedData[i, 2];

            totalOldSalary += oldSalary;
            totalNewSalary += newSalary;
            totalBonus += bonus;

            // Display the salary details for each employee
            Console.WriteLine($"{oldSalary,10:C} | {bonus,12:C} | {newSalary,10:C}");
        }

        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine($"Total Old Salary: {totalOldSalary:C}");
        Console.WriteLine($"Total New Salary: {totalNewSalary:C}");
        Console.WriteLine($"Total Bonus: {totalBonus:C}");
    }

    static void Main()
    {
        int numEmployees = 10; // Number of employees
        double[,] employeeData = DetermineSalaryAndYears(numEmployees); // Get the salary and years of service for each employee
        double[,] updatedData = CalculateNewSalaryAndBonus(employeeData, numEmployees); // Calculate the new salary and bonus for each employee

        // Calculate and display the totals
        CalculateAndDisplayTotals(updatedData, numEmployees);
    }
}
