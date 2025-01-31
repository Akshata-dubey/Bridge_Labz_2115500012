using System;

class Largest
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();

        string longestWord = FindLongestWord(input);
        Console.WriteLine("Largest Word"+ longestWord);
    }

    static string FindLongestWord(string sentence)
    {
        int maxLength = 0, wordLength = 0, startIndex = 0, longestStart = 0;
        sentence += " "; // Append space to detect the last word

        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] != ' ') // Counting word length
            {
                if (wordLength == 0) startIndex = i; // Start of a new word
                wordLength++;
            }
            else if (wordLength > 0) // Word ends
            {
                if (wordLength > maxLength) // Update longest word details
                {
                    maxLength = wordLength;
                    longestStart = startIndex;
                }
                wordLength = 0; // Reset for next word
            }
        }

        // Extract the longest word
        return sentence.Substring(longestStart, maxLength);
    }
}
