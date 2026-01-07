using System;
using System.Collections.Generic;
interface IReservable
{
    void ReserveItem(string borrowerName);
    bool CheckAvailability();
}

//  ABSTRACT CLASS 
abstract class LibraryItem
{
    // Encapsulation: protected + private
    protected int itemId;
    protected string title;
    protected string author;

    // Sensitive data (secured)
    private string borrowerName;
    private bool isAvailable = true;

    public LibraryItem(int itemId, string title, string author)
    {
        this.itemId = itemId;
        this.title = title;
        this.author = author;
    }
    public abstract int GetLoanDuration();

    public void GetItemDetails()
    {
        Console.WriteLine("Item ID : " + itemId);
        Console.WriteLine("Title   : " + title);
        Console.WriteLine("Author  : " + author);
        Console.WriteLine("Loan Days: " + GetLoanDuration());
    }

    //Protected helpers for child classes
    protected void SetBorrower(string name)
    {
        borrowerName = name;
        isAvailable = false;
    }

    protected bool IsAvailable()
    {
        return isAvailable;
    }
}

// BOOK 
class Book : LibraryItem, IReservable
{
    public Book(int id, string title, string author)
        : base(id, title, author) { }

    public override int GetLoanDuration()
    {
        return 14; 
    }

    public void ReserveItem(string borrowerName)
    {
        if (CheckAvailability())
        {
            SetBorrower(borrowerName);
            Console.WriteLine("Book reserved by " + borrowerName);
        }
        else
        {
            Console.WriteLine("Book is not available");
        }
    }

    public bool CheckAvailability()
    {
        return IsAvailable();
    }
}

//  MAGAZINE 
class Magazine : LibraryItem, IReservable
{
    public Magazine(int id, string title, string author)
        : base(id, title, author) { }

    public override int GetLoanDuration()
    {
        return 7;
    }

    public void ReserveItem(string borrowerName)
    {
        if (CheckAvailability())
        {
            SetBorrower(borrowerName);
            Console.WriteLine("Magazine reserved by " + borrowerName);
        }
        else
        {
            Console.WriteLine("Magazine is not available");
        }
    }

    public bool CheckAvailability()
    {
        return IsAvailable();
    }
}

// DVD 
class DVD : LibraryItem, IReservable
{
    public DVD(int id, string title, string author)
        : base(id, title, author) { }

    public override int GetLoanDuration()
    {
        return 3; // 3 days
    }

    public void ReserveItem(string borrowerName)
    {
        if (CheckAvailability())
        {
            SetBorrower(borrowerName);
            Console.WriteLine("DVD reserved by " + borrowerName);
        }
        else
        {
            Console.WriteLine("DVD is not available");
        }
    }

    public bool CheckAvailability()
    {
        return IsAvailable();
    }
}

// MAIN SYSTEM 
class LibraryManagementSystem
{
    static void Main()
    {
        // Polymorphism: base class reference
        List<LibraryItem> items = new List<LibraryItem>
        {
            new Book(101, "Mathematics", "Rd sharama"),
            new Magazine(102, "National Geographic", "S.chand"),
            new DVD(103, "Development", "Bhanu dagur")
        };

        foreach (LibraryItem item in items)
        {
            item.GetItemDetails();

            // Interface-based behavior
            if (item is IReservable)
            {
                IReservable reservable = (IReservable)item;

                if (reservable.CheckAvailability())
                {
                    reservable.ReserveItem("Bhanu Dagur");
                }
                else
                {
                    Console.WriteLine("Item already reserved");
                }
            }

            Console.WriteLine("-----------------------------------");
        }
    }
}
