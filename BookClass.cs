using System;

class Books
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    // Default Constructor
    public Books()
    {
        Title = "Unknown";
        Author = "Unknown";
        Price = 0.0;
    }

    // Parameterized Constructor
    public Books(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    public void DisplayBookDetails()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Price: {Price}");
    }
}

// Example Usage
class Programer
{
    // static void Main()
    // {
        // Books defaultBook = new Books();
        // defaultBook.DisplayBookDetails();

        // Books customBook = new Books("C# Programming", "John Doe", 29.99);
        // customBook.DisplayBookDetails();
    // }
}
