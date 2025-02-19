using System;
using System.Collections.Generic;

class Learner
{
    public string Name { get; set; }
    public List<Subject> EnrolledSubjects { get; set; }

    // Constructor
    public Learner(string name)
    {
        Name = name;
        EnrolledSubjects = new List<Subject>();
    }

    // Method to enroll a learner in a subject
    public void EnrollSubject(Subject subject)
    {
        EnrolledSubjects.Add(subject);
    }
}

class Instructor
{
    public string Name { get; set; }

    // Constructor
    public Instructor(string name)
    {
        Name = name;
    }

    // Method to assign an instructor to a subject
    public void AssignSubject(Subject subject)
    {
        subject.Instructor = this;
    }
}

class Subject
{
    public string Name { get; set; }
    public Instructor Instructor { get; set; }

    // Constructor
    public Subject(string name)
    {
        Name = name;
    }
}

class Program
{
    static void Main()
    {
        var learner1 = new Learner("Alice");
        var learner2 = new Learner("Bob");
        var instructor = new Instructor("Dr. Smith");

        var subject1 = new Subject("Computer Science");
        var subject2 = new Subject("Mathematics");
        var subject3 = new Subject("Physics");

        // Assigning instructor to the subjects
        instructor.AssignSubject(subject1);
        instructor.AssignSubject(subject2);
        instructor.AssignSubject(subject3);

        // Enrolling learners in the subjects
        learner1.EnrollSubject(subject1);
        learner1.EnrollSubject(subject2);
        learner2.EnrollSubject(subject2);
        learner2.EnrollSubject(subject3);

        // Displaying subject enrollment and instructor details
        Console.WriteLine($"{learner1.Name} and {learner2.Name} enrolled in the following subjects taught by {instructor.Name}:");

        // Displaying subject details for learner1
        foreach (var subject in learner1.EnrolledSubjects)
        {
            Console.WriteLine($"{learner1.Name} is enrolled in {subject.Name}");
        }

        // Displaying subject details for learner2
        foreach (var subject in learner2.EnrolledSubjects)
        {
            Console.WriteLine($"{learner2.Name} is enrolled in {subject.Name}");
        }
    }
}
