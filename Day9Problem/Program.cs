using System;
using System.Collections.Generic;

namespace Day9Problem
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Program");
            LinkedList<AddressBook> list = new LinkedList<AddressBook>();
            while (true)
            {
                AddressBook.Index();
                int Check = Convert.ToInt32(Console.ReadLine());
                switch (Check)
                {
                    case 1:
                        Console.WriteLine("Enter FirstName");
                        string FirstName = Console.ReadLine();
                        Console.WriteLine("Enter LastName");
                        string LastName = Console.ReadLine();
                        Console.WriteLine("Enter Address");
                        string Address = Console.ReadLine();
                        Console.WriteLine("Enter City");
                        string City = Console.ReadLine();
                        Console.WriteLine("Enter State");
                        string State = Console.ReadLine();
                        Console.WriteLine("Enter PhoneNumber");
                        string PhoneNumber = Console.ReadLine();
                        Console.WriteLine("Enter Zip");
                        string Zip = Console.ReadLine();
                        Console.WriteLine("Enter Email");
                        string Email = Console.ReadLine();

                        list.AddLast(new AddressBook(FirstName, LastName, Address, City, State, PhoneNumber, Zip, Email));
                        break;

                    case 2:
                        System.Environment.Exit(0);
                        break;
                }

            }
        }
    }
}
