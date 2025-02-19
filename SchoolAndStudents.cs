using System;
using System.Collections.Generic;

class SchoolAndStudents
{
    public string Name { get; set; }
    public List<StudentInSchool> Students { get; set; }

    // Constructor 
    public SchoolAndStudents(string name)
    {
        Name = name;
        Students = new List<StudentInSchool>();
    }

    // Method to add a student to the school
    public void AddStudent(StudentInSchool student)
    {
        Students.Add(student);
    }
}

class StudentInSchool
{
    public string Name { get; set; }
    public List<SchoolCourse> Courses { get; set; }

    // Constructor 
    public StudentInSchool(string name)
    {
        Name = name;
        Courses = new List<SchoolCourse>();
    }

    // Method to enroll a student in a course
    public void EnrollInCourse(SchoolCourse course)
    {
        Courses.Add(course);
        course.AddStudent(this);
    }

    // Method to show all courses the student is enrolled in
    public void ShowEnrolledCourses()
    {
        Console.WriteLine($"{Name} is enrolled in the following courses:");
        foreach (var course in Courses)
        {
            Console.WriteLine(course.Name);
        }
    }
}

class SchoolCourse
{
    public string Name { get; set; }
    public List<StudentInSchool> Students { get; set; }

    // Constructor 
    public SchoolCourse(string name)
    {
        Name = name;
        Students = new List<StudentInSchool>();
    }

    // Method to add a student to the course
    public void AddStudent(StudentInSchool student)
    {
        Students.Add(student);
    }

    // Method to show all students enrolled in the course
    public void ShowEnrolledStudents()
    {
        Console.WriteLine($"The following students are enrolled in {Name}:");
        foreach (var student in Students)
        {
            Console.WriteLine(student.Name);
        }
    }
}

class Program
{
    static void Main()
    {
        var school = new SchoolAndStudents("Greenwood High");
        var student1 = new StudentInSchool("Alice");
        var student2 = new StudentInSchool("Bob");
        var course1 = new SchoolCourse("Math");
        var course2 = new SchoolCourse("Science");

        // Enrolling students in courses
        student1.EnrollInCourse(course1);
        student2.EnrollInCourse(course1);
        student1.EnrollInCourse(course2);

        // Adding students to the school
        school.AddStudent(student1);
        school.AddStudent(student2);

        // Displaying enrolled courses and students
        student1.ShowEnrolledCourses();
        course1.ShowEnrolledStudents();
        course2.ShowEnrolledStudents();
    }
}
