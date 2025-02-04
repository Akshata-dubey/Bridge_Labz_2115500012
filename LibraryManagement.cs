using System;

class LibraryBooks
{
    public string ISBN;
    protected string Title;
    private string Author;

    public void SetAuthor(string author)
    {
        Author = author;
    }

    public string GetAuthor()
    {
        return Author;
    }
}

class DigitalBook : LibraryBooks
{
    public void Display()
    {
        Console.WriteLine($"ISBN: {ISBN}, Title: {Title}");
    }
}

class LibraryManagement
{
    // static void Main()
    // {
        // // Create an instance of DigitalBook
        // DigitalBook ebook = new DigitalBook();
        
        // // Set values for ISBN, Title, and Author
        // ebook.ISBN = "123-456-789";
        // ebook.SetAuthor("J.K. Rowling");
        
        // // Display book details
        // ebook.Display();
        // Console.WriteLine($"Author: {ebook.GetAuthor()}");
    // }
}
