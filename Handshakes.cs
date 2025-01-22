using System;

class Handshakes
{
    static void Main()
    {
        // Ask the user to input the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Calculate the maximum number of handshakes using the formula (n * (n - 1)) / 2
        int maxHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        // Display the result
        Console.WriteLine("The maximum number of handshakes among " + numberOfStudents + 
                          " students is " + maxHandshakes + ".");
    }
}
