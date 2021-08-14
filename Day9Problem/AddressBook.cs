using System;
using System.Collections.Generic;
using System.Text;

namespace Day9Problem
{
    class AddressBook
    {
        public string FirstName, LastName, Address, City, State, Email;
        public string PhoneNumber, Zip;

        public AddressBook(string FirstName, string LastName, string Address, string City, string State, string PhoneNumber, string Zip, string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.PhoneNumber = PhoneNumber;
            this.Zip = Zip;
            this.Email = Email;
        }

        public static void Index()
        {

            Console.WriteLine("Select Option");
            Console.WriteLine("Enter 1 to Add Contact");
            Console.WriteLine("Enter 2 to View Contacts");
            Console.WriteLine("Enter 3 to Edit Contacts");
            Console.WriteLine("Enter 4 to Exit");

        }
    }
}