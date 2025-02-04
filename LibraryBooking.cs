using System;

class LibraryBook
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }
    public bool IsAvailable { get; set; }

    // Default Constructor
    public LibraryBook()
    {
        Title = "Unknown";
        Author = "Unknown";
        Price = 0.0;
        IsAvailable = true;
    }

    // Parameterized Constructor
    public LibraryBook(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
        IsAvailable = true;
    }

    // Borrow Book Method
    public void BorrowBook()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine($"{Title} has been borrowed.");
        }
        else
        {
            Console.WriteLine($"{Title} is already borrowed.");
        }
    }

    // Display Book Details
    public void DisplayBookDetails()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Price: {Price}, Available: {IsAvailable}");
    }
}

// Main Program to Test Book Class
class LibraryBooking
{
    // static void Main()
    // {
        // // Using Default Constructor
        // LibraryBook book1 = new LibraryBook();
        // Console.WriteLine("Default Book Details:");
        // book1.DisplayBookDetails();

        // // Using Parameterized Constructor
        // LibraryBook book2 = new LibraryBook("C# Programming", "John Doe", 499.99);
        // Console.WriteLine("\nParameterized Book Details:");
        // book2.DisplayBookDetails();

        // // Borrowing Book
        // Console.WriteLine("\nAttempting to Borrow Book:");
        // book2.BorrowBook();
        // book2.DisplayBookDetails();

        // // Trying to Borrow Again
        // Console.WriteLine("\nAttempting to Borrow Again:");
        // book2.BorrowBook();
    // }
}
