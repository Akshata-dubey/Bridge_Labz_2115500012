using System;

class RemoveCharacter
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.Write("Enter the character to remove: ");
        char charToRemove = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Move to the next line after input

        string modifiedString = RemoveChar(input, charToRemove);
        Console.WriteLine("Modified String: " + modifiedString);
    }

    static string RemoveChar(string str, char ch)
    {
        char[] result = new char[str.Length];
        int index = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != ch) // Keep only non-matching characters
            {
                result[index] = str[i];
                index++;
            }
        }

        return new string(result, 0, index); // Convert to string
    }
}
