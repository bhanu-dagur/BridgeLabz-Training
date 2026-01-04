using System;
class Book
{ 
    static string libraryName="Centeral Library";
    public readonly int isbn;
    public string title;
    public string author;  
    public Book(int isbn, string title, string author)
    {
       this.isbn = isbn;
       this.title = title;
       this.author = author;
    }
    public void DisplayInfo()
    {
        Console.WriteLine("Library Name: " + libraryName);
        Console.WriteLine("ISBN: " + isbn);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
    }
    public static void DisplayLibraryName()
    {
        Console.WriteLine("Library Name: " + libraryName);
    }

}
class LibrarySystem
{
    public static void Main()
    {
        Book book1 = new Book(101, "Godhan", "Munshi Prem Chand");
        Book book2 = new Book(102, "Computer", "Bhanu Dagur");

        if (book1 is Book)
        {
            book1.DisplayInfo();
        }
        if (book2 is Book)
        {
            book2.DisplayInfo();
        }

        Book.DisplayLibraryName();
    }
}