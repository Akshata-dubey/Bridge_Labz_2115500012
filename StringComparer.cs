using System;

class StringComparer
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        int result = CompareStrings(str1, str2);

        if (result < 0)
            Console.WriteLine(str1 + " comes before " + str2 + " in lexicographical order.");
        else if (result > 0)
            Console.WriteLine(str1 + " comes after " + str2 + " in lexicographical order.");
        else
            Console.WriteLine("Both strings are equal.");
    }

    static int CompareStrings(string s1, string s2)
    {
        int minLength = s1.Length < s2.Length ? s1.Length : s2.Length;

        for (int i = 0; i < minLength; i++)
        {
            if (s1[i] < s2[i]) return -1; // s1 comes first
            if (s1[i] > s2[i]) return 1;  // s2 comes first
        }

        // If one string is a prefix of the other
        if (s1.Length < s2.Length) return -1;
        if (s1.Length > s2.Length) return 1;

        return 0; // Both strings are equal
    }
}
