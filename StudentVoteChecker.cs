using System;

public class StudentVoteChecker
{
    // Method to check if a student can vote
    public static bool CanStudentVote(int age)
    {
        if (age < 0) // Validate for negative age
        {
            return false;
        }
        return age >= 18; // Return true if age is 18 or above, otherwise false
    }

    public static void Main(string[] args)
    {
        // Array to hold ages of 10 students
        int[] studentAges = new int[10];

        Console.WriteLine("Enter the age of 10 students:");

        for (int i = 0; i < studentAges.Length; i++)
        {
            Console.Write($"Enter age for student {i + 1}: ");
            bool validInput = int.TryParse(Console.ReadLine(), out studentAges[i]);

            if (!validInput || studentAges[i] < 0)
            {
                Console.WriteLine("Invalid input. Age cannot be negative or non-numeric. Try again.");
                i--; // Repeat input for the same student
                continue;
            }
        }

        Console.WriteLine("\nVoting Eligibility Results:");
        for (int i = 0; i < studentAges.Length; i++)
        {
            bool canVote = CanStudentVote(studentAges[i]);
            Console.WriteLine($"Student {i + 1} (Age: {studentAges[i]}) - {(canVote ? "Can Vote" : "Cannot Vote")}");
        }
    }
}
