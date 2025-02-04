//using System;

//class Student
//{
//    // Static variable shared across all students
//    private static string UniversityName = "Gla University";
//    private static int totalStudents = 0;

//    // Readonly variable (cannot be modified after initialization)
//    public readonly int RollNumber;
//    public string Name;
//    public string Grade;

//    // Constructor using 'this' keyword to initialize attributes
//    public Student(int RollNumber, string Name, string Grade)
//    {
//        this.RollNumber = RollNumber; // Readonly variable can only be assigned here
//        this.Name = Name;
//        this.Grade = Grade;
//        totalStudents++; // Increment total student count
//    }

//    // Static method to display total number of students
//    public static void DisplayTotalStudents()
//    {
//        Console.WriteLine("Total Students Enrolled: " + totalStudents);
//    }

//    // Method to display student details (checks instance using 'is' operator)
//    public void DisplayStudentDetails()
//    {
//        if (this is Student)
//        {
//            Console.WriteLine("University: " + UniversityName);
//            Console.WriteLine("Student Name: " + Name);
//            Console.WriteLine("Roll Number: " + RollNumber);
//            Console.WriteLine("Grade: " + Grade);
//        }
//        else
//        {
//            Console.WriteLine("Invalid student object.");
//        }
//    }
//}

//class Student_Details
//{
//    static void Main()
//    {
//        // Creating Student objects
//        Student stud1 = new Student(101, "Akshata Dubey", "A");
//        Student stud2 = new Student(102, "Om Dubey", "B");

//        // Display student details
//        stud1.DisplayStudentDetails();
//        Console.WriteLine();
//        stud2.DisplayStudentDetails();
//        Console.WriteLine();

//        // Display total students enrolled
//        Student.DisplayTotalStudents();
//    }
//}
