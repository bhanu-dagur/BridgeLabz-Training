
using Newtonsoft.Json;
using System.Text;
using System.Xml;

class AddressBookServiceImpl : IAddressBookService
{
    private Dictionary<string, AddressBook> addressBooks = [];

    // UC 5 + UC 7
    public void CreateAddressBook(string name)
    {
        if (!addressBooks.ContainsKey(name))
        {
            addressBooks.Add(name, new AddressBook(name));
            Console.WriteLine("Address book created successfully!");
        }
        else
        {
            Console.WriteLine("Address book already exists");

        }
    }

    // UC 1 + UC 6
    public void AddContact(string bookName)
    {
        if(!addressBooks.ContainsKey(bookName)){
            Console.WriteLine("Address book not found");
            return;
        }
        var book=addressBooks[bookName];

        var contact = new Contact();

        Console.WriteLine("Enter first name:");
        contact.FirstName= Console.ReadLine();

        Console.WriteLine("Enter last name:");
        contact.LastName = Console.ReadLine()??string.Empty;

        Console.WriteLine("Enter Phone Number:");
        contact.PhoneNumber = Console.ReadLine()??string.Empty;

        //Duplicate Check
        if (book.Contacts.Contains(contact))
        {
            Console.WriteLine("Duplicate Contact Not Allowed!");
            return;
        }
        
        Console.WriteLine("Enter Address:");
        contact.Address = Console.ReadLine()??string.Empty;

        Console.WriteLine("Enter City:");
        contact.City = Console.ReadLine()??string.Empty;

        Console.WriteLine("Enter State:");
        contact.State = Console.ReadLine()?? string.Empty;

        Console.WriteLine("Enter Zip Code:");
        contact.ZipCode = Console.ReadLine()??string.Empty;


        Console.WriteLine("Enter Email:");
        contact.Email = Console.ReadLine()??string.Empty;

        book.Contacts.Add(contact);
        Console.WriteLine("Contact added successfully!");

        
        
    }
    // UC 2
    public void EditContact(string bookName)
    {
        if(!addressBooks.ContainsKey(bookName)){
            Console.WriteLine("Address book not found");
            return;
        }
        var book=addressBooks[bookName];

        Console.WriteLine("Enter first name to edit: ");
        string name = Console.ReadLine()??string.Empty;
        Console.WriteLine("Enter mobile number to edit: ");
        string number = Console.ReadLine()??string.Empty;

        // var contact = book.Contacts.Find(c => c.FirstName == name);
        Contact? contact = null;
        foreach (var item in book.Contacts)
        {
            if (item.FirstName != null && item.PhoneNumber != null && 
                item.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase) && 
                item.PhoneNumber.Equals(number))
            {
                contact = item;
                break;
            }
        }

        if (contact == null)
        {
            Console.WriteLine("Contact not found!");
            return;
        }

        Console.WriteLine("Enter new first name:");
        contact.FirstName = Console.ReadLine();

        Console.WriteLine("Enter new last name:");
        contact.LastName = Console.ReadLine()??string.Empty;

        Console.WriteLine("Enter new Address:");
        contact.Address = Console.ReadLine()??string.Empty;

        Console.WriteLine("Enter new City:");
        contact.City = Console.ReadLine()??string.Empty;

        Console.WriteLine("Enter new State:");
        contact.State = Console.ReadLine()??string.Empty;

        Console.WriteLine("Enter new Zip Code:");
        contact.ZipCode = Console.ReadLine()??string.Empty;

        Console.WriteLine("Enter new Phone Number:");
        contact.PhoneNumber = Console.ReadLine()??string.Empty;

        Console.WriteLine("Enter new Email:");
        contact.Email = Console.ReadLine()??string.Empty;

        Console.WriteLine("Contact edited successfully!");


    }
    // UC 3
    public void DeleteContact(string bookName)
    {
        if(!addressBooks.ContainsKey(bookName)){
            Console.WriteLine("Address book not found");
            return;
        }
        Console.WriteLine("Enter First Name:");
        string? name = Console.ReadLine();
        Console.WriteLine("Enter Mobile Number:");
        string? number = Console.ReadLine();

        var book=addressBooks[bookName];
        var contact = book.Contacts.Find(c => c.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase) 
        && c.PhoneNumber.Equals(number));

        if (contact == null)
        {
            Console.WriteLine("Contact not found!");
            return;
        }

        book.Contacts.Remove(contact);
        Console.WriteLine("Contact deleted successfully!");
    }
    // UC 4
    public void DisplayContacts(string bookName)
    {
        if(!addressBooks.ContainsKey(bookName)){
            Console.WriteLine("Address book not found");
            return;
        }
        var book=addressBooks[bookName];
        foreach (var contact in book.Contacts)
        {
            Console.WriteLine(contact);
        }
        
    }
    // UC 8
    public void SearchByCityOrState(string search)
    {
        List<Contact> result=[];
        foreach(var book in addressBooks)
        {
            foreach(var contact in book.Value.Contacts)
            {
                if(contact.City.Equals(search, StringComparison.OrdinalIgnoreCase) 
                    || contact.State.Equals(search, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(contact);
                }
            }
        }
        foreach(var contact in result)
        {
            Console.WriteLine(contact);
        }
    }

    // UC 9
    public void ViewByCityOrState()
    {
        Dictionary<string,List<Contact>> result = new Dictionary<string,List<Contact>>();
        foreach(var book in addressBooks)
        {
            foreach(var contact in book.Value.Contacts)
            {
                if(!result.ContainsKey(contact.City))
                {
                    result.Add(contact.City,new List<Contact>());
                }
                result[contact.City].Add(contact);
            }
        }
        foreach(var city in result)
        {
            Console.WriteLine($"Contacts in {city.Key} are:");
            foreach(var contact in city.Value)
            {
                Console.WriteLine(contact);
            }
        }
    }

    // UC 10
    public void CountByCityOrState(string search)
    {
        int count = 0;
        foreach(var book in addressBooks)
        {
            foreach(var contact in book.Value.Contacts)
            {
                if(contact.City.Equals(search, StringComparison.OrdinalIgnoreCase) 
                    || contact.State.Equals(search, StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }
        }
        Console.WriteLine($"Contacts in {search} are: {count}");
    }
    // UC 11
    public void SortByName(string bookName)
    {
        if (!addressBooks.ContainsKey(bookName))  return;

        List<Contact> contacts = addressBooks[bookName].Contacts;

        contacts.Sort((c1, c2) =>
        {
            // return c1.FirstName.CompareTo(c2.FirstName, StringComparison.OrdinalIgnoreCase);
            int firstNameComparison = 
                string.Compare(c1.FirstName, c2.FirstName, StringComparison.OrdinalIgnoreCase);

            if (firstNameComparison != 0)
                return firstNameComparison;

            return string.Compare(c1.LastName, c2.LastName, StringComparison.OrdinalIgnoreCase);
        });

        foreach (var contact in contacts)
        {
            Console.WriteLine(contact);
        }
    }
    // UC 12
    public void SortByCityStateOrZip(string bookName,string field)
    {
        if (!addressBooks.ContainsKey(bookName))
        {
            Console.WriteLine("Book not found");
            return;
        }
        
        var contacts=addressBooks[bookName].Contacts;
        contacts.Sort ((c1,c2) =>
        {
            if (field.Equals("city", StringComparison.OrdinalIgnoreCase))
            {
                return string.Compare(c1.City, c2.City, StringComparison.OrdinalIgnoreCase);
            }
            else if (field.Equals("state", StringComparison.OrdinalIgnoreCase))
            {
                return string.Compare(c1.State, c2.State, StringComparison.OrdinalIgnoreCase);
            }
            else if (field.Equals("zip", StringComparison.OrdinalIgnoreCase))
            {
                return string.Compare(c1.ZipCode, c2.ZipCode, StringComparison.OrdinalIgnoreCase);
            }
            return 0;
            
        });
    }

}