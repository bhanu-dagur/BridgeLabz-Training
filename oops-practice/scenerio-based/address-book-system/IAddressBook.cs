using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal interface IAddressBook
    {
        void AddContact(); //UC-2 Add Persons details
        void DisplayContact();
        void EditContact(); //UC-3 Edit Persons details
        void DeleteContact(); //UC-4 Delete Persons details
        void SearchContact(); //UC-5 Search Persons by city or state
        void SortPersonByName(); //UC-6 Sort Person by Name
    }
}
