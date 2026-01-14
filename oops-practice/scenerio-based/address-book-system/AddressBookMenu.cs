using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBookMenu
    {
        IAddressBook addressBookUtility = new AddressBookUtility();
        public void Menu()
        {
            Console.WriteLine("******* WELCOME TO ADDRESS BOOK SYSTEM ********");
            while (true)
            {
                Console.WriteLine("PRESS 1. FOR ADD CONTACT DETAILS"); // UC-2 Add Persons details 
                Console.WriteLine("PRESS 2. FOR DISPLAY ALL CONTACT DETAILS");
                Console.WriteLine("PRESS 3. FOR EDIT CONTACT DETAILS BY NAME");
                Console.WriteLine("PRESS 4. FOR DELETE CONTACT DETAILS BY NAME");
                Console.WriteLine("PRESS 5. FOR EXIT");
                int choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        addressBookUtility.AddContact();
                        break;
                    case 2:
                        addressBookUtility.DisplayContact();
                        break;
                    case 3:
                        addressBookUtility.EditContact();
                        break;
                    case 4:
                        addressBookUtility.DeleteContact();
                        break;
                    case 5:
                        Console.WriteLine("THANKS FOR USING OUR APPLICATION");
                        return;
                    default:
                        Console.WriteLine("YOU HAVE ENTERED INVALID INPUT");
                        break;
                }

                Console.WriteLine("-----------------------------------------------");
            }
        }
    }
}
