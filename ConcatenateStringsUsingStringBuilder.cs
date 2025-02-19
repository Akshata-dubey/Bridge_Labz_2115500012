using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Append
{
    static void Main(string[] args)
    {
        //String variable
        string x = " ";
        Console.WriteLine("Program to append to word:");
        //take input and make it StringBuilder
        StringBuilder sb = new StringBuilder(Console.ReadLine());
        //Loop to take input and append till he writes exit 
        while (x != "exit")
        {
            Console.WriteLine("Enter the Word to append(Write exit to exit): ");
            x = Console.ReadLine();
            if (x != "exit")
            {
                sb.Append(x);
                Console.WriteLine("Current String: " + sb);
            }
        }
        Console.WriteLine("THE END.");
    }

}