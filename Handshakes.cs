using System;

public class Handshakes
{
    // Method to calculate the maximum number of handshakes
    public static int CalculateHandshakes(int numberOfStudents)
    {
        return (numberOfStudents * (numberOfStudents - 1)) / 2;
    }

    public static void Main(string[] args)
    {
        // Take input for the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        // Calculate the maximum number of handshakes
        int handshakes = CalculateHandshakes(numberOfStudents);

        // Output the result
        Console.WriteLine($"The maximum number of handshakes among {numberOfStudents} students is: {handshakes}");
    }
}
