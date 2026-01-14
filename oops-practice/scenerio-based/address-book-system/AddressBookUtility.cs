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
                string field = Console.ReadLine();

            for (int i = 0; i < addressBook.Length; i++)
            {
                if (addressBook[i] != null)
                {
                    if (addressBook[i].firstName == name)
                    {
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
