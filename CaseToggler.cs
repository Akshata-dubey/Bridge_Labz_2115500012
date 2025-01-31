using System;

class CaseToggler
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string toggledString = ToggleCase(input);
        Console.WriteLine("Toggled case: " + toggledString); // Using concatenation instead of $
    }

    static string ToggleCase(string str)
    {
        char[] charArray = str.ToCharArray(); // Convert string to character array

        for (int i = 0; i < charArray.Length; i++)
        {
            if (charArray[i] >= 'A' && charArray[i] <= 'Z') // Uppercase to lowercase
                charArray[i] = (char)(charArray[i] + 32);
            else if (charArray[i] >= 'a' && charArray[i] <= 'z') // Lowercase to uppercase
                charArray[i] = (char)(charArray[i] - 32);
        }

        return new string(charArray);
    }
}
