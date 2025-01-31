using System;

public class HandshakeCalculator
{
    // Method to calculate the maximum number of handshakes
    public static int CalculateHandshakes(int numberOfStudents)
    {
        // Using the combination formula to calculate handshakes
        return (numberOfStudents * (numberOfStudents - 1)) / 2;
    }

    public static void Main(string[] args)
    {
        // Taking input for the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        // Validating the number of students
        if (numberOfStudents <= 1)
        {
            Console.WriteLine("At least 2 students are needed to form handshakes.");
            return;
        }

        // Calculate the maximum number of handshakes
        int handshakes = CalculateHandshakes(numberOfStudents);

        // Display the result
        Console.WriteLine($"The maximum number of handshakes among {numberOfStudents} students is: {handshakes}");
    }
}
