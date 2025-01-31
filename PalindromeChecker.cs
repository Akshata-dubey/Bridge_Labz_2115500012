using System;

class PalindromeChecker
{
    static void Main()
    {
        // Get input from the user
        string input = GetInput("Enter a string to check if it's a palindrome: ");
        
        // Check if the input is a palindrome
        bool isPalindrome = IsPalindrome(input);
        
        // Display the result
        DisplayResult(isPalindrome, input);
    }

    // Function to get input from the user
    static string GetInput(string message)
    {
        Console.Write(message);
        return Console.ReadLine();
    }

    // Function to check if a string is a palindrome
    static bool IsPalindrome(string str)
    {
        // Remove any spaces and convert to lowercase for case-insensitive comparison
        str = str.Replace(" ", "").ToLower();

        // Check if the string is equal to its reverse
        int length = str.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (str[i] != str[length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }

    // Function to display the result
    static void DisplayResult(bool isPalindrome, string input)
    {
        if (isPalindrome)
        {
            Console.WriteLine($"'{input}' is a palindrome.");
        }
        else
        {
            Console.WriteLine($"'{input}' is not a palindrome.");
        }
    }
}
