using System;

class Book
{
    // Attributes (Fields)
    private string title;
    private string author;
    private double price;

    // Constructor to initialize attributes
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    // Method to display book details
    public void DisplayDetails()
    {
        Console.WriteLine("Book Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
       
    }

    static void Main()
    {
        // Taking user input for book details
        Console.Write("Enter Book Title: ");
        string title = Console.ReadLine();

        Console.Write("Enter Author Name: ");
        string author = Console.ReadLine();

        Console.Write("Enter Book Price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        // Creating Book object
        Book book = new Book(title, author, price);

        // Displaying book details
        Console.WriteLine("\nBook Details:");
        book.DisplayDetails();
    }
}
