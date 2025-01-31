using System;

class Substring
{
    static void Main()
    {
        Console.Write("Enter the main string: ");
        string mainString = Console.ReadLine();

        Console.Write("Enter the substring to find: ");
        string subString = Console.ReadLine();

        int occurrences = CountSubstringOccurrences(mainString, subString);
        Console.WriteLine("Occurrences of"+ subString+ "is"+ occurrences);
    }

    static int CountSubstringOccurrences(string text, string pattern)
    {
        int count = 0;
        int textLength = text.Length;
        int patternLength = pattern.Length;

        if (patternLength == 0 || patternLength > textLength)
            return 0; 

        for (int i = 0; i <= textLength - patternLength; i++)
        {
            bool match = true;

            // Check if substring matches
            for (int j = 0; j < patternLength; j++)
            {
                if (text[i + j] != pattern[j])
                {
                    match = false;
                    break;
                }
            }

            if (match)
                count++;
        }

        return count;
    }
}
