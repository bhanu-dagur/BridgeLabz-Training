namespace LibraryManagementSystem;

class LibraryMenu
{
    public void Menu()
    {
        ILibrary obj=new LibraryUtilityImpl();

        Console.WriteLine("Welcame to the Central Library");
        while (true)
        {
            Console.WriteLine("Enter 1 to add book");
            Console.WriteLine("Enter 2 to display all books");
            Console.WriteLine("Enter 3 to search book");
            Console.WriteLine("Enter 4 to update book status");
            Console.WriteLine("Enter 5 to exit");

            int choose =Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    obj.AddBook();
                    break;
                case 2:
                    obj.DisplayBook();
                    break;
                case 3:
                    Console.WriteLine("Enter the book title to search");
                    string title=Console.ReadLine();
                    obj.SearchBook(title);
                    break;
                case 4:
                    Console.WriteLine("Enter the book title to update status");
                    string title2=Console.ReadLine();
                    obj.UpdateBook(title2);
                    break;
                case 5:
                    Console.WriteLine("Thanks for using Central Library");
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            
        }


        
    }
}