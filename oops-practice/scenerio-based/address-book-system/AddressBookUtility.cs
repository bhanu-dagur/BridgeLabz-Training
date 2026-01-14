using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem 
{
    internal class AddressBookUtility : IAddressBook
    {
        private AddressBook[] addressBook = new AddressBook[10];  // UC-5 store multiple contacts
        

        public void AddContact() // UC-2 Add Persons details
        {
            AddressBook contact = new AddressBook();
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
        public void EditContact() // UC-3 Edit Persons details
        {
            

            Console.WriteLine("ENTER THE NAME OF THE CONTACT YOU WANT TO EDIT");
            string name= Console.ReadLine();

            Console.WriteLine("ENTER THE FIELD YOU WANT TO EDIT IN PASCAL CASE");
            Console.WriteLine("FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email");

            string field = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < addressBook.Length; i++)
            {
                if (addressBook[i] != null)
                {
                    if (addressBook[i].firstName == name)
                    {
                        found = true;
                        if (field == "FirstName")
                        {
                            Console.WriteLine("Enter First Name");
                            addressBook[i].firstName = Console.ReadLine();
                        }
                        else if (field == "LastName")
                        {
                            Console.WriteLine("Enter Last Name");
                            addressBook[i].lastName = Console.ReadLine();
                        }
                        else if (field == "Address")
                        {
                            Console.WriteLine("Enter Address");
                            addressBook[i].address = Console.ReadLine();
                        }
                        else if (field == "City")
                        {
                            Console.WriteLine("Enter City");
                            addressBook[i].city = Console.ReadLine();
                        }
                        else if (field == "State")
                        {
                            Console.WriteLine("Enter State");
                            addressBook[i].state = Console.ReadLine();
                        }
                        else if (field == "Zip")
                        {
                            Console.WriteLine("Enter Zip");
                            addressBook[i].zip = Console.ReadLine();
                        }
                        else if (field == "PhoneNumber")
                        {
                            Console.WriteLine("Enter Phone Number");
                            addressBook[i].phoneNumber = Console.ReadLine();
                        }
                        else if (field == "Email")
                        {
                            Console.WriteLine("Enter Email");
                            addressBook[i].email = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("INVALID INPUT");
                        }
                    }
                }
            }
            if (found == false)
            {
                Console.WriteLine("CONTACT NOT FOUND");
            }
            
        }
        public void DeleteContact()// UC-4 Delete Persons details
        { 
            bool found = false;
            Console.WriteLine("ENTER THE NAME OF THE CONTACT YOU WANT TO DELETE");
            string name = Console.ReadLine();
            for (int i = 0; i < addressBook.Length; i++)
            {
                if (addressBook[i] != null)
                {
                    if (addressBook[i].firstName == name)
                    {
                        found = true;
                        
                        for (int j = i; j < addressBook.Length - 1; j++)
                        {
                            addressBook[j] = addressBook[j + 1];
                        }
                        addressBook[addressBook.Length - 1] = null;
                        Console.WriteLine("Contact Deleted Successfully");
                        break;
                    }
                }
            }
            if(found == false)
            {
                Console.WriteLine("CONTACT NOT FOUND");
            }
        }
        public void DisplayContact() 
        {
            bool isEmpty = false;

            for(int i = 0; i < addressBook.Length; i++)
            {
                if(addressBook[i] != null)
                {
                    isEmpty = true;
                    Console.WriteLine(addressBook[i]);
                }
            }
            if(!isEmpty)
            {
                Console.WriteLine("ADDRESS BOOK IS EMPTY");
            }
        }
    }
}
