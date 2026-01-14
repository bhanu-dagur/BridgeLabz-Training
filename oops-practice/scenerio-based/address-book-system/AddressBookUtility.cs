using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem 
{
    internal class AddressBookUtility : IAddressBook
    {
        private AddressBook[] addressBook = new AddressBook[10];

        
        AddressBook contact = new AddressBook();
        public void AddContact() // UC-2 Add Persons details
        {
            Console.WriteLine("Enter First Name");
            contact.firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            contact.lastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contact.address = Console.ReadLine();
            Console.WriteLine("Enter City");
            contact.city = Console.ReadLine();
            Console.WriteLine("Enter State");
            contact.state = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            contact.zip = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            contact.phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email");
            contact.email = Console.ReadLine();


            for(int i = 0; i < addressBook.Length; i++)
            {
                if(addressBook[i] == null)
                {
                    addressBook[i] = contact;
                    Console.WriteLine("Contact Added Successfully");
                    break;
                }
            }
        }
        public void DisplayContact() 
        {
            for(int i = 0; i < addressBook.Length; i++)
            {
                if(addressBook[i] != null)
                {
                    Console.WriteLine(addressBook[i]);
                }
            }
        }
    }
}
