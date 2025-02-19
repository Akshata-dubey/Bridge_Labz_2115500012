using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Reverse
{
    //Method to reverse string 
    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static void Main()
    {
        //Main method
        Console.WriteLine("Enter the text");
        string input = Console.ReadLine();
        //Stringbuilder
        StringBuilder sb = new StringBuilder(input);
        sb = new StringBuilder(ReverseString(sb.ToString()));
        Console.WriteLine(sb);

    }
}

