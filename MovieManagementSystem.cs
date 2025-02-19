using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Film
{
    public string Name;
    public string DirectorName;
    public int ReleaseYear;
    public double ReviewRating;
    public Film Previous, Next;

    public Film(string name, string directorName, int releaseYear, double reviewRating)
    {
        Name = name;
        DirectorName = directorName;
        ReleaseYear = releaseYear;
        ReviewRating = reviewRating;
        Previous = Next = null;
    }
}

class FilmCollection
{
    private Film first, last;

    public void AddFilmAtEnd(string name, string directorName, int releaseYear, double reviewRating)
    {
        Film newFilm = new Film(name, directorName, releaseYear, reviewRating);
        if (first == null)
        {
            first = last = newFilm;
            return;
        }
        last.Next = newFilm;
        newFilm.Previous = last;
        last = newFilm;
    }

    public void RemoveFilm(string name)
    {
        Film temp = first;
        while (temp != null)
        {
            if (temp.Name == name)
            {
                if (temp.Previous != null) temp.Previous.Next = temp.Next;
                if (temp.Next != null) temp.Next.Previous = temp.Previous;
                if (temp == first) first = temp.Next;
                if (temp == last) last = temp.Previous;
                return;
            }
            temp = temp.Next;
        }
    }

    public void ShowFilmsForward()
    {
        Film temp = first;
        while (temp != null)
        {
            Console.WriteLine($"Name: {temp.Name}, Director: {temp.DirectorName}, Year: {temp.ReleaseYear}, Rating: {temp.ReviewRating}");
            temp = temp.Next;
        }
    }

    public void ShowFilmsReverse()
    {
        Film temp = last;
        while (temp != null)
        {
            Console.WriteLine($"Name: {temp.Name}, Director: {temp.DirectorName}, Year: {temp.ReleaseYear}, Rating: {temp.ReviewRating}");
            temp = temp.Previous;
        }
    }
}

class Program
{
    static void Main()
    {
        FilmCollection filmList = new FilmCollection();
        filmList.AddFilmAtEnd("Inception", "Nolan", 2010, 8.8);
        filmList.AddFilmAtEnd("Interstellar", "Nolan", 2014, 8.6);
        filmList.ShowFilmsForward();

        Console.WriteLine("Removing Inception...");
        filmList.RemoveFilm("Inception");
        filmList.ShowFilmsForward();
    }
}
