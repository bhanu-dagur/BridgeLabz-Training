using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        private string FirstName;
        private string LastName;
        private string Address;
        private string City;
        private string State;
        private string Zip;
        private string PhoneNumber;
        private string Email;

        public string firstName
        {
            get { return FirstName; }
            set { FirstName = value; }
        }
        public string lastName
        {
            get { return LastName; }
            set { LastName = value; }
        }
        public string address
        {
            get { return Address; }
            set { Address = value; }
        }
        public string city
        {
            get { return City; }
            set { City = value; }
        }
        public string state
        {
            get { return State; }
            set { State = value; }
        }
        public string zip
        {
            get { return Zip; }
            set { Zip = value; }
        }

        public string phoneNumber
        {
            set { PhoneNumber = value; }
            get { return PhoneNumber; }

        }
        public string email
        {
            set { Email = value; }
            get { return Email; }
        }
        public override string ToString()
        {
              return "FirstName: "+FirstName + ",  LastName: " + LastName + ",  Address: " + Address + ",  City: " + City + 
                ",  State: " + State + ",  Zip: " + Zip + ",  PhoneNumber: " + PhoneNumber + ",  Email: " + Email;
        }

    }
}
