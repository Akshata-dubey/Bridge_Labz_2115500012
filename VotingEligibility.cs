using System;

class VotingEligibility
{
    static void Main()
    {
        // Input: Get the age from the user
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        // Check if the person is eligible to vote (age >= 18)
        if (age >= 18)
        {
            // Output: If the person can vote
            Console.WriteLine("The person's age is " + age + " and can vote.");
        }
        else
        {
            // Output: If the person cannot vote
            Console.WriteLine("The person's age is " + age + " and cannot vote.");
        }
    }
}
