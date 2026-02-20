class AddressBookMenu
{
    AddressBookServiceImpl addressBookServiceImpl = new AddressBookServiceImpl();
    public void Show()
    {
        Console.WriteLine("WELCOME TO ADDRESS BOOK SYSTEM");

        while (true)
        {
            Console.WriteLine("\n1.Create AddressBook");
            Console.WriteLine("2.Display AddressBook");
            Console.WriteLine("3.Add Contact");
            Console.WriteLine("4.Edit Contact");
            Console.WriteLine("5.Delete Contact");
            Console.WriteLine("6.Search By City Or State");
            Console.WriteLine("7.View By City Or State");
            Console.WriteLine("8.Count By City Or State");
            Console.WriteLine("9.Sort By Name");
            Console.WriteLine("10.Sort By City , State Or Zip");
            
            Console.WriteLine("0.Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Book Name:");
                    string bookName = Console.ReadLine();
                    addressBookServiceImpl.CreateAddressBook(bookName);
                    break;
                case 2:
                    Console.WriteLine("Enter Book Name:");
                    bookName = Console.ReadLine();
                    addressBookServiceImpl.DisplayContacts(bookName);
                    break;
                case 3:
                    Console.WriteLine("Enter Book Name:");
                    bookName = Console.ReadLine();
                    addressBookServiceImpl.AddContact(bookName);
                    break;
                case 4:
                    Console.WriteLine("Enter Book Name:");
                    bookName = Console.ReadLine();
                    addressBookServiceImpl.EditContact(bookName);
                    break;
                case 5:
                    Console.WriteLine("Enter Book Name:");
                    bookName = Console.ReadLine();
                    addressBookServiceImpl.DeleteContact(bookName);
                    break;
                case 6:
                    Console.WriteLine("Enter Book Name:");
                    bookName = Console.ReadLine();
                    addressBookServiceImpl.SearchByCityOrState(bookName);
                    break;
                case 7:
                    addressBookServiceImpl.ViewByCityOrState();
                    break;
                case 8:
                    Console.WriteLine("Enter City Or State:");
                    string search = Console.ReadLine();
                    addressBookServiceImpl.CountByCityOrState(search);
                    break;
                case 9:
                    Console.WriteLine("Enter Book Name:");
                    bookName = Console.ReadLine();
                    addressBookServiceImpl.SortByName(bookName);
                    break;
                case 10:
                    Console.WriteLine("Enter Book Name:");
                    bookName = Console.ReadLine();
                    addressBookServiceImpl.SortByCityStateOrZip(bookName,"city");
                    break;
                case 0:
                    return;
            }

        }
        
        
    }
}



