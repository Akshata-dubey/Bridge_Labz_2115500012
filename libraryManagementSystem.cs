using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice_VS
{
    class libraryManagementSystem
    {
        private static string LibraryName = "City Library";


        public string Title;
        public string Author;
        public readonly string ISBN;

        public static void DisplayLibraryName()
        {
            Console.Write("Library Name : " + LibraryName);
        }

        public libraryManagementSystem(string Title, string Author, string ISBN)
        {
            this.Title = Title;
            this.Author = Author;
            this.ISBN = ISBN;
        }

        public  void DisplayLibraryDetails()
        {
            if (this is libraryManagementSystem)
            {
                Console.WriteLine(LibraryName);
                Console.WriteLine("Title Name: " + Title);
                
                Console.WriteLine("Author Name: " + Author);
                Console.WriteLine("ISBN Number: " + ISBN);
            }
            else
            {
                Console.WriteLine("Invalid Book Details!");
            }

        }
        
    }
    class CheckBook {
        static void Main(string[] agrs) {
            libraryManagementSystem obj1 = new libraryManagementSystem("The Road Not Taken", "Robert Frost", "23456789");
            libraryManagementSystem obj2 = new libraryManagementSystem("The Story Of My Life", "Helen Keller", "09876543");

            obj1.DisplayLibraryDetails();
            Console.WriteLine();
            obj2.DisplayLibraryDetails();  
            Console.WriteLine();


            libraryManagementSystem.DisplayLibraryName();
        }
    }
}