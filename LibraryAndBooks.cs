using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// class to represent books
class LibraryAndBooks
{
    //Initialize variables
    public string Title { get; }
    public string Author { get; }
    //Constructor
    public LibraryAndBooks(string title, string author)
    {
        Title = title;
        Author = author;
    }
    //Display method for book
    public void Display()
    {
        Console.WriteLine($"Book: {Title}, Author: {Author}");
    }

}
//class to represent Library
class Library
{
    //Initialize variable
    public string Name { get; }
    public List<LibraryAndBooks> Books { get; } = new List<LibraryAndBooks>();
    //Constructor
    public Library(string name)
    {
        Name = name;
    }
    //Add book  method
    public void AddBook(LibraryAndBooks book)
    {
        if (!Books.Contains(book))
        {
            Books.Add(book);
        }
        else
        {
            Console.WriteLine($"The book {book.Title} is already available");
        }
    }
    //Method to display to books
    public void DisplayBooks()
    {
        Console.WriteLine($"Library:  {Name} has following books: ");
        foreach (var book in Books)
        {
            book.Display();
        }
        Console.WriteLine("------------------------------------");

    }
}
//Main class to execute program
class Program
{
    static void Main(string[] args)
    {
        //creating independent programs
        LibraryAndBooks book1 = new LibraryAndBooks("The Story of My Life", "Helen Keller");
        LibraryAndBooks book2 = new LibraryAndBooks("The Road Not Taken", "Robert Frost");
        LibraryAndBooks book3 = new LibraryAndBooks("Julius Caesar", "William Shakespeare");
        //creating library objects
        Library library1 = new Library("The Central Library");
        Library library2 = new Library("The Royal Library");
        //adding books
        library1.AddBook(book1);
        library1.AddBook(book2);
        library1.AddBook(book2);
        library2.AddBook(book2);
        library2.AddBook(book3);
        //Display books
        library1.DisplayBooks();
        library2.DisplayBooks();

    }
}

