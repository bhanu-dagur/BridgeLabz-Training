using System;
class Book
{
    private string title {get; set;}
    private int publicationYear {get; set;}

    public Book(string title, int publicationYear)
    {
        this.title = title;
        this.publicationYear = publicationYear;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Title: " + this.title);
        Console.WriteLine("Publication Year: " + this.publicationYear);
    }
}
class Author : Book
{
    private string name {get; set;}
    private string bio {get; set;}
    public Author(string title, int publicationYear, string name, string bio) : base(title, publicationYear)
    {
        this.name = name;
        this.bio = bio;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Author: " + this.name);
        Console.WriteLine("Bio: " + this.bio);
    }
}
class LibraryMangement
{
    static void Main(string[] args)
    {
        Author book1 = new Author("Hard Programming", 1925, "Bhanu dagur", "A book by Bhanu dagur.");
        book1.DisplayInfo();
    }
}