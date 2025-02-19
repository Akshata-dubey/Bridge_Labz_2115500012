using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Persons
{
    public string Name { get; set; }
}

class Employeese : Persons
{
    public int EmployeeId { get; set; }
}

class Program
{
    static void Main()
    {
        Employeese emp = new Employeese { Name = "Alice", EmployeeId = 101 };
        Console.WriteLine($"Employee: {emp.Name}, ID: {emp.EmployeeId}");
    }
}
