using System;

class StudentGrades
{
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents;

        // Validate the number of students
        while (!int.TryParse(Console.ReadLine(), out numberOfStudents) || numberOfStudents <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }

        // Arrays to store marks, percentages, and grades
        int[] physicsMarks = new int[numberOfStudents];
        int[] chemistryMarks = new int[numberOfStudents];
        int[] mathsMarks = new int[numberOfStudents];
        double[] percentages = new double[numberOfStudents];
        char[] grades = new char[numberOfStudents];

        // Input marks for each student
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"\nEnter marks for Student {i + 1}:");

            physicsMarks[i] = GetValidMarks("Physics");
            chemistryMarks[i] = GetValidMarks("Chemistry");
            mathsMarks[i] = GetValidMarks("Maths");

            // Calculate percentage
            percentages[i] = (physicsMarks[i] + chemistryMarks[i] + mathsMarks[i]) / 3.0;

            // Determine grade
            grades[i] = GetGrade(percentages[i]);
        }

        // Display results
        Console.WriteLine("\nResults:");
        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tPercentage\tGrade");
        Console.WriteLine("-----------------------------------------------------------");

        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"{i + 1}\t{physicsMarks[i]}\t{chemistryMarks[i]}\t\t{mathsMarks[i]}\t{percentages[i]:0.00}%\t\t{grades[i]}");
        }
    }

    // Method to get valid marks
    static int GetValidMarks(string subject)
    {
        int marks;
        while (true)
        {
            Console.Write($"Enter marks in {subject} (0-100): ");
            if (int.TryParse(Console.ReadLine(), out marks) && marks >= 0 && marks <= 100)
                return marks;

            Console.WriteLine("Invalid input. Please enter a value between 0 and 100.");
        }
    }

    // Method to determine grade based on percentage
    static char GetGrade(double percentage)
    {
        if (percentage >= 90)
            return 'A';
        if (percentage >= 75)
            return 'B';
        if (percentage >= 50)
            return 'C';
        return 'D';
    }
}
