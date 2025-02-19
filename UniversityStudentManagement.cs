using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Practices._04_02_2025
{
    class Student
    {
        private static int TotalStudents = 0;
        private static string UniversityName = "Global University";
        public string Name;
        public readonly int RollNumber;
        public string Grade;

        public Student(string name, int rollNumber, string grade)
        {
            this.Name = name;
            this.RollNumber = rollNumber;
            this.Grade = grade;
            TotalStudents++;
        }

        public static void DisplayTotalStudents()
        {
            Console.WriteLine($"Total Enrolled Students: {TotalStudents}");
        }

        public void DisplayStudentDetails()
        {
            if (this is Student)
            {
                Console.WriteLine($"{UniversityName} | Name: {Name}, Roll No: {RollNumber}, Grade: {Grade}");
            }
        }
    }

    class UniversityManagement
    {
        static void Main()
        {
            Student s1 = new Student("Kashish", 27, "A");
            Student s2 = new Student("Aishwarya", 03, "B");

            s1.DisplayStudentDetails();
            s2.DisplayStudentDetails();

            Student.DisplayTotalStudents();
        }
    }

}
