using System;

class LibrarySystem
{
    static void Main()
    {
        string[,] books =
        {
            {"Harry Potter", "J.K. Rowling", "Available"},
            {"Atomic Habits", "James Clear", "Available"},
            {"The Alchemist", "Paulo Coelho", "Checked Out"},
            {"Clean Code", "Robert Martin", "Available"}
        };

        while (true)
        {
            Console.WriteLine("\n Library Menu");
            Console.WriteLine("1. Display Books");
            Console.WriteLine("2. Search Book");
            Console.WriteLine("3. Checkout Book");
            Console.WriteLine("4. Return Book");
            Console.WriteLine("5. Exit");

            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DisplayBooks(books);
                    break;

                case 2:
                    SearchBook(books);
                    break;

                case 3:
                    CheckoutBook(books);
                    break;

                case 4:
                    ReturnBook(books);
                    break;

                case 5:
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    //  Display all books
    static void DisplayBooks(string[,] books)
    {
        Console.WriteLine("\nTitle\t\tAuthor\t\tStatus");

        for (int i = 0; i < books.GetLength(0); i++)
        {
            Console.WriteLine(books[i,0]+" | "+books[i,1]+" | "+ books[i,2]);
        }
    }

    //  Partial title search
    static void SearchBook(string[,] books)
    {
        Console.Write("Enter book title to search: ");
        string search = Console.ReadLine().ToLower();
        bool found = false;

        for (int i = 0; i < books.GetLength(0); i++)
        {
            if (books[i,0].ToLower().Contains(search))
            {
                Console.WriteLine(books[i,0]+" | "+books[i,1]+ " | "+books[i,2]);
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Book not found!");
        }
    }

    //  Checkout book
    static void CheckoutBook(string[,] books)
    {
        Console.Write("Enter book title to checkout: ");
        string title = Console.ReadLine().ToLower();

        for (int i = 0; i < books.GetLength(0); i++)
        {
            if (books[i,0].ToLower().Equals(title))
            {
                if (books[i,2] == "Available")
                {
                    books[i,2] = "Checked Out";
                    Console.WriteLine("Book successfully checked out.");
                }
                else
                {
                    Console.WriteLine("Book already checked out.");
                }
                return;
            }
        }

        Console.WriteLine("Book not found!");
    }

    //  Return book
    static void ReturnBook(string[,] books)
    {
        Console.Write("Enter book title to return: ");
        string title = Console.ReadLine().ToLower();

        for (int i = 0; i < books.GetLength(0); i++)
        {
            if (books[i,0].ToLower().Equals(title))
            {
                books[i,2] = "Available";
                Console.WriteLine("Book returned successfully.");
                return;
            }
        }

        Console.WriteLine("Book not found!");
    }
}
