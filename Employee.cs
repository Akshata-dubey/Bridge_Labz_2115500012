using System;

class Employee
{
    // Attributes (Fields)
    private string name;
    private int id;
    private double salary;

    // Constructor to initialize attributes
    public Employee(string name, int id, double salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    // Method to display employee details
    public void DisplayDetails()
    {
        Console.WriteLine("Employee ID: " + id);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Salary: $" + salary);
       
    }

    static void Main()
    {
        // Creating employee objects
        Employee emp1 = new Employee("John Doe", 101, 50000);
        Employee emp2 = new Employee("Alice Smith", 102, 60000);

        // Displaying employee details
        Console.WriteLine("Employee Details:\n");
        emp1.DisplayDetails();
        emp2.DisplayDetails();
    }
}
