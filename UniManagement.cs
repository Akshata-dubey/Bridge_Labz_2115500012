using System;

class Student
{
    public int RollNumber;
    protected string Name;
    private double CGPA;

    public void SetCGPA(double cgpa)
    {
        CGPA = cgpa;
    }

    public double GetCGPA()
    {
        return CGPA;
    }

    // Adding a public method to access the Name property
    public string GetName()
    {
        return Name;
    }

    // Adding a public method to set the Name property
    public void SetName(string name)
    {
        Name = name;
    }
}

class PostgraduateStudent : Student
{
    public void Display()
    {
        // Access Name using the GetName method
        Console.WriteLine($"Student Name: {GetName()}");
    }
}

class UniManagement
{
    // static void Main()
    // {
        // // Create an instance of PostgraduateStudent
        // PostgraduateStudent student = new PostgraduateStudent();
        
        // // Set the Name and CGPA
        // student.SetName("John Doe");
        // student.SetCGPA(3.9);
        
        // // Display student details
        // student.Display();
        // Console.WriteLine($"CGPA: {student.GetCGPA()}");
    // }
}
