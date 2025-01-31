using System;

class Anagram
{
    static void Main()
    {
        Console.Write("Enter the first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter the second string: ");
        string str2 = Console.ReadLine();

        bool areAnagrams = AreAnagrams(str1, str2);

        if (areAnagrams)
            Console.WriteLine("The strings are anagrams.");
        else
            Console.WriteLine("The strings are not anagrams.");
    }

    static bool AreAnagrams(string s1, string s2)
    {
        // If the lengths are not the same, they cannot be anagrams
        if (s1.Length != s2.Length)
            return false;

        // Create an array to count character frequencies
        int[] charCount = new int[256]; // Assuming ASCII characters

        // Count characters for the first string
        for (int i = 0; i < s1.Length; i++)
        {
            charCount[s1[i]]++;
            charCount[s2[i]]--;
        }

        // If all counts are zero, the strings are anagrams
        foreach (var count in charCount)
        {
            if (count != 0)
                return false;
        }

        return true;
    }
}
