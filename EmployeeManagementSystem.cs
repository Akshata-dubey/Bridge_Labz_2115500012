using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Practice {
    class EmployeeManagementSystem
    {
        private static string CompanyName = "Capgemini";
        private static int Total = 0;
        public string Name;
        public readonly string Id;
        public string Designation;

        public static void TotalEmployee()
        {
            Console.WriteLine("Total Number Of Employee: " + Total);
        }

        public EmployeeManagementSystem(string Name, string Id, string Designation)
        {
            this.Name = Name;
            this.Id = Id;
            this.Designation = Designation;
            Total++;
        }

        public void EmployeeDetails()
        {
            if (this is EmployeeManagementSystem)
            {
                Console.WriteLine(CompanyName);
                Console.WriteLine("Name of Employee: " + Name);
                Console.WriteLine("Employee ID: " + Id);
                Console.WriteLine("Designation: " + Designation);
                

            }
            else
                Console.WriteLine("Invalid Employee Details!");
        }

    }
    class Employee
    {
        public static void Main()
        {
            EmployeeManagementSystem em1 = new EmployeeManagementSystem("Kashish", "2115500078", "Analyst");
            EmployeeManagementSystem em2 = new EmployeeManagementSystem("Akshata", "2115500012", "Analyst");

            em1.EmployeeDetails();
            Console.WriteLine();
            em2.EmployeeDetails();
            Console.WriteLine();

            EmployeeManagementSystem.TotalEmployee();
        }
    }

}
