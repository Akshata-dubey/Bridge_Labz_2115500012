using System;

class Employees
{
    // Public field: Employee ID
    public int EmployeeID;

    // Protected field: Department (accessible in subclasses)
    protected string Department;

    // Private field: Salary (cannot be accessed directly outside the class)
    private double Salary;

    // Method to set salary
    public void SetSalary(double salary)
    {
        Salary = salary;
    }

    // Method to get salary
    public double GetSalary()
    {
        return Salary;
    }

    // Constructor to initialize employee details
    public Employees(int employeeID, string department)
    {
        EmployeeID = employeeID;
        Department = department;
    }
}

class Manager : Employees
{
    // Constructor to initialize manager details
    public Manager(int employeeID, string department)
        : base(employeeID, department) // Call the base class (Employee) constructor
    {
    }

    // Method to display manager details
    public void Display()
    {
        Console.WriteLine($"Manager ID: {EmployeeID}, Department: {Department}");
    }
}

class EmployeeRecords
{
    // Main entry point of the program
    // static void Main()
    // {
        // // Create a new Manager instance with employee ID and department
        // Manager manager = new Manager(101, "IT");

        // // Set salary for the manager
        // manager.SetSalary(75000);

        // // Display manager details
        // manager.Display();

        // // Get and display manager salary
        // Console.WriteLine($"Manager Salary: {manager.GetSalary()}");
    // }
}
