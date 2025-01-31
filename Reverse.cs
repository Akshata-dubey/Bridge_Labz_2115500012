using System;

class Reverse
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        
        char[] charArray = input.ToCharArray(); // Convert string to character array
        int left = 0, right = charArray.Length - 1;
        
        // Swap characters from start to end
        while (left < right)
        {
            char temp = charArray[left];
            charArray[left] = charArray[right];
            charArray[right] = temp;

            left++;
            right--;
        }

        // Convert back to string
        string reversedString = new string(charArray);
        Console.WriteLine("Reserved String: "+ reversedString);
    }
}
