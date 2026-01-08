
using System;

// Movie node with previous and next reference
class MovieNode
{
    public string Title;
    public double Rating;
    public MovieNode Prev;
    public MovieNode Next;

    public MovieNode(string title, double rating)
    {
        Title = title;
        Rating = rating;
        Prev = Next = null;
    }
}

class MovieList
{
    private MovieNode head = null;
    private MovieNode tail = null;

    // Add movie at the end
    public void AddMovie(string title, double rating)
    {
        MovieNode node = new MovieNode(title, rating);

        if (head == null)
        {
            head = tail = node;
            return;
        }

        tail.Next = node;
        node.Prev = tail;
        tail = node;
    }

    // Display movies forward
    public void DisplayForward()
    {
        MovieNode temp = head;
        while (temp != null)
        {
            Console.WriteLine("Title: " + temp.Title + ", Rating: " + temp.Rating);
            temp = temp.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        MovieList movies = new MovieList();

        movies.AddMovie("Dhurandhar", 9.5);
        movies.AddMovie("Dangal", 9.0);
        movies.AddMovie("Bahubali", 8.8);

        movies.DisplayForward();
    }
}
