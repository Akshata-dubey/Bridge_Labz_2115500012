using System;

class MostFrequentCharacterFinder
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char mostFrequentChar = FindMostFrequentCharacter(input);
        Console.WriteLine("Most Frequent Character: '" + mostFrequentChar + "'");
    }

    static char FindMostFrequentCharacter(string str)
    {
        int[] freq = new int[256]; // ASCII table size (supports extended characters)
        int maxCount = 0;
        char mostFrequent = '\0';

        // Count frequency of each character
        for (int i = 0; i < str.Length; i++)
        {
            freq[str[i]]++; // Increment count for this character

            if (freq[str[i]] > maxCount)
            {
                maxCount = freq[str[i]];
                mostFrequent = str[i];
            }
        }

        return mostFrequent;
    }
}
