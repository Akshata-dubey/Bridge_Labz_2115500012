using System;

class CustomReplace
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        Console.Write("Enter the word to replace: ");
        string oldWord = Console.ReadLine();

        Console.Write("Enter the new word: ");
        string newWord = Console.ReadLine();

        string modifiedSentence = ReplaceWord(sentence, oldWord, newWord);
        Console.WriteLine("Modified Sentence: " + modifiedSentence);
    }

    static string ReplaceWord(string sentence, string oldWord, string newWord)
    {
        int index = 0;
        string result = "";

        // Loop through the sentence and find occurrences of the oldWord
        while ((index = sentence.IndexOf(oldWord, index)) != -1)
        {
            result += sentence.Substring(0, index) + newWord;
            sentence = sentence.Substring(index + oldWord.Length);
        }

        result += sentence; // Append the remaining part of the sentence
        return result;
    }
}
