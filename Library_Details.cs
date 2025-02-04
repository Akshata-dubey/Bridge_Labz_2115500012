//using System;

//namespace OOPS
//{
//    class Library_Details
//    {
//        // Static variable
//        public static string LibraryName = "City Library";

//        // Readonly and instance variables
//        public string Title;
//        public readonly string ISBN;
//        public string Author;

//        // Constructor
//        public Library_Details(string title, string ISBN, string author)
//        {
//            this.Title = title;
//            this.ISBN = ISBN;
//            this.Author = author.Trim();  // Trim removes extra spaces
//        }

//        // Static method to display Library name
//        public static void DisplayLibraryName()
//        {
//            Console.WriteLine("The library name is: " + LibraryName);
//        }

//        // Instance method to display book details
//        public void DisplayBookDetails()
//        {
//            if (this is Library_Details)
//            {
//                Console.WriteLine("Library Name: " + LibraryName);
//                Console.WriteLine("Title: " + Title);
//                Console.WriteLine("ISBN: " + ISBN);
//                Console.WriteLine("Author: " + Author);
//            }
//            else
//            {
//                Console.WriteLine("Invalid book entry");
//            }
//        }
//    }

//    class Program  // Changed from Library_Details to Program
//    {
//        static void Main()
//        {
//            // Creating book objects
//            Library_Details ob1 = new Library_Details("Silence", "67368736", "Ruthor");
//            Library_Details ob2 = new Library_Details("1984", "12334", "Scottt");

//            // Display book details
//            ob1.DisplayBookDetails();
//            Console.WriteLine();
//            ob2.DisplayBookDetails();
//            Console.WriteLine();

//            // Printing library name
//            Library_Details.DisplayLibraryName();  // Corrected static method call
//        }
//    }
//}
