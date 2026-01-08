using System;

class BookNode
{
    public string Title;
    public string Author;
    public string Genre;
    public int BookId;
    public bool IsAvailable;

    public BookNode Next;
    public BookNode Prev;

    public BookNode(string title, string author, string genre, int bookId, bool isAvailable)
    {
        Title = title;
        Author = author;
        Genre = genre;
        BookId = bookId;
        IsAvailable = isAvailable;
    }
}

class LibraryList
{
    BookNode head;
    BookNode tail;

    // 🔹 Reusable Print Method
    void PrintBook(BookNode book)
    {
        Console.WriteLine("Title          : " + book.Title 
                         +"\nAuthor       : " + book.Author 
                         +"\n Genre       : " + book.Genre 
                         +"\nBook ID      : " + book.BookId
                         +"\nAvailability : " + book.IsAvailable);
        Console.WriteLine("----------------------------------");
    }

    public void AddBookAtStart(BookNode node)
    {
        if (head == null)
        {
            head = tail = node;
        }
        else
        {
            node.Next = head;
            head.Prev = node;
            head = node;
        }
    }

    public void AddBookAtEnd(BookNode node)
    {
        if (head == null)
        {
            head = tail = node;
        }
        else
        {
            tail.Next = node;
            node.Prev = tail;
            tail = node;
        }
    }

    public void AddAtSpecificPosition(BookNode node, int position)
    {
        if (position == 1)
        {
            AddBookAtStart(node);
            return;
        }

        BookNode temp = head;
        for (int i = 1; i < position - 1 && temp != null; i++)
            temp = temp.Next;

        if (temp == null)
        {
            Console.WriteLine("Invalid position");
            return;
        }

        if (temp.Next == null)
        {
            AddBookAtEnd(node);
            return;
        }

        node.Next = temp.Next;
        node.Prev = temp;
        temp.Next.Prev = node;
        temp.Next = node;
    }

    public void RemoveBook(int bookId)
    {
        if (head == null)
        {
            Console.WriteLine("Library empty");
            return;
        }

        BookNode temp = head;
        while (temp != null && temp.BookId != bookId)
            temp = temp.Next;

        if (temp == null)
        {
            Console.WriteLine("Book not found");
            return;
        }

        if (temp == head)
            head = head.Next;

        if (temp == tail)
            tail = tail.Prev;

        if (temp.Prev != null)
            temp.Prev.Next = temp.Next;

        if (temp.Next != null)
            temp.Next.Prev = temp.Prev;

        Console.WriteLine("Book removed");
    }

    public void SearchBook(string title, string author)
    {
        BookNode temp = head;
        while (temp != null)
        {
            if (temp.Title == title && temp.Author == author)
            {
                Console.WriteLine("Book found:");
                PrintBook(temp);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Book not found");
    }

    public void UpdateAvailability(int bookId, bool isAvailable)
    {
        BookNode temp = head;
        while (temp != null)
        {
            if (temp.BookId == bookId)
            {
                temp.IsAvailable = isAvailable;
                Console.WriteLine("Availability updated");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Book not found");
    }

    public void DisplayForward()
    {
        BookNode temp = head;
        while (temp != null)
        {
            PrintBook(temp);
            temp = temp.Next;
        }
    }

    public void DisplayBackward()
    {
        BookNode temp = tail;
        while (temp != null)
        {
            PrintBook(temp);
            temp = temp.Prev;
        }
    }

    public int CountBooks()
    {
        int count = 0;
        BookNode temp = head;
        while (temp != null)
        {
            count++;
            temp = temp.Next;
        }
        return count;
    }
}

class LibraryManagement
{
    static void Main()
    {
        LibraryList list = new LibraryList();

        list.AddBookAtStart(new BookNode("Book 1", "Author 1", "Genre 1", 1, true));
        list.AddBookAtEnd(new BookNode("Book 2", "Author 2", "Genre 2", 2, false));
        list.AddAtSpecificPosition(new BookNode("Book 3", "Author 3", "Genre 3", 3, true), 2);

        Console.WriteLine("\n--- Forward Display ---");
        list.DisplayForward();

        list.RemoveBook(2);

        Console.WriteLine("\n--- After Removal ---");
        list.DisplayForward();

        list.SearchBook("Book 1", "Author 1");

        list.UpdateAvailability(1, false);

        Console.WriteLine("\n--- Reverse Display ---");
        list.DisplayBackward();

        Console.WriteLine("\nTotal Books: " + list.CountBooks());
    }
}
