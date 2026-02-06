namespace LibraryManagementSystem;
using System;

class LibraryUtilityImpl : ILibrary
{
    Book [] books = new Book[50];

    public void AddBook()
    {
        Console.WriteLine("Enter the book title");
        string title=Console.ReadLine();

        Console.WriteLine("Enter the author of book");
        string author=Console.ReadLine();

        Console.WriteLine("Enter (true/false) isAvailabal status");
        bool status=Convert.ToBoolean(Console.ReadLine());

        Book book=new Book(title,author,status);
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] == null)
            {
                books[i] = book;
                Console.WriteLine("Book added successfully");
                return;
            }
        }
        Console.WriteLine("Library is full");
    }

    public void SearchBook(string title)
    {
        for(int i = 0; i < books.Length; i++)
        {
            if(books[i]!=null && books[i].Title.Contains(title, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Book found\n"+books[i].ToString());
                return;
            }
        }
        Console.WriteLine("Book not found");
        
    }

    public void UpdateBook(string title)
    {
        for(int i = 0; i < books.Length; i++)
        {
            if(books[i]!=null && books[i].Title.Contains(title, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(books[i].ToString());
                Console.WriteLine("Enter the boolean status Value");
                bool val=Convert.ToBoolean(Console.ReadLine());
                books[i].Status=val;
            }
        }
        
    }
    public void DisplayBook()
    {
        for(int i = 0; i < books.Length; i++)
        {
            if (books[i] != null)
            {
                Console.WriteLine(books[i].ToString());
            }
            else
            {
                return;
            }
        }
    }
}