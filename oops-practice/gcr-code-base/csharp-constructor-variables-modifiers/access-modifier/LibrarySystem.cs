using System;
class Book
{
    public string title;
    // protected should be accessible in derived classes and within the same class 
    protected string author;
    // private should be accessible only within the same class
    private int isbn;

    public Book(string title, string author, int isbn)
    {
        this.title = title;
        this.author = author;
        this.isbn = isbn;
    }
    public void setAuthor(string author)
    {
        this.author = author;
    }
    public string getAuthor()
    {
        return author;
    }
    public void DisplayInfo()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("ISBN: " + isbn);
    }
    
    
}
class EBook : Book
{
    public EBook(string title, string author, int isbn) : base(title, author, isbn)
    {
        
    }
    public void ModifyAuthor(string newAuthor)
    {
        setAuthor(newAuthor);
        Console.WriteLine("Author modified to: " + getAuthor());
    }
    public void ShowTitle()
    {
        Console.WriteLine("Title of the eBook: " + title);
    }
    
}
class LibrarySystem
{
    static void Main(string[] args)
    {
        Book book = new Book("Godhan", "Munshi Prem Chand", 1);
        book.DisplayInfo();

        EBook eBook = new EBook("Computer", "Krishna", 2);
        eBook.DisplayInfo();
        eBook.ModifyAuthor("Jane Doe");
        eBook.ShowTitle();
    }
}