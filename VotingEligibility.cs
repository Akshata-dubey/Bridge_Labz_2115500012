using System;

class VotingEligibility
{
    static void Main()
    {
        int[] ages = new int[10];  // Array to store the ages of 10 students

        // Take user input for the age of each student
        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write("Enter age for student " + (i + 1) + ": ");
            string input = Console.ReadLine();

            // Try to parse the input to an integer
            if (int.TryParse(input, out ages[i]))
            {
                // Check for invalid age (negative age)
                if (ages[i] < 0)
                {
                    Console.WriteLine("Invalid age for student " + (i + 1));
                    ages[i] = -1; // Mark as invalid
                }
                else if (ages[i] >= 18)
                {
                    Console.WriteLine("The student with the age " + ages[i] + " can vote.");
                }
                else
                {
                    Console.WriteLine("The student with the age " + ages[i] + " cannot vote.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for student " + (i + 1) + ", please enter a valid number.");
            }
        }
    }
}
