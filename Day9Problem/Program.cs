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
                        foreach (AddressBook Info in list)
                        {
                            Console.WriteLine(Info.FirstName + ", " + Info.LastName + ", " + Info.Address + ", " + Info.City + ", " + Info.State + ", " + Info.PhoneNumber + ", " + Info.Zip + ", " + Info.Email);
                        }
                        break;

                    case 3:
                        Console.WriteLine(" Enter Name to Edit else leave blank ");
                        string Name = Console.ReadLine();
                        
                        foreach (AddressBook Info in list)
                            if (Name == (Info.FirstName))
                            {
                                Console.WriteLine("Enter new FName");
                                string NewName = Console.ReadLine();
                                Info.FirstName = NewName;

                            }
                            else if (Name == (Info.LastName))
                            {
                                Console.WriteLine("Enter new LstName");
                                string NewLstName = Console.ReadLine();
                                Info.LastName = NewLstName;

                            }
                            else if (Name == (Info.Address))
                            {
                                Console.WriteLine("Enter new Address");
                                string NewAddress = Console.ReadLine();
                                Info.Address = NewAddress;

                            }
                            else if (Name == (Info.City))
                            {
                                Console.WriteLine("Enter new City");
                                string NewCity = Console.ReadLine();
                                Info.City = NewCity;

                            }
                            else if (Name == (Info.State))
                            {
                                Console.WriteLine("Enter new State");
                                string NewState = Console.ReadLine();
                                Info.State = NewState;

                            }


                            else if (Name == (Info.PhoneNumber))
                            {
                                Console.WriteLine("Enter new Number");
                                string NewNumber = Console.ReadLine();
                                Info.PhoneNumber = NewNumber;
                            }
                            else if (Name == (Info.Zip))
                            {
                                Console.WriteLine("Enter new Zip");
                                string NewZip = Console.ReadLine();
                                Info.Zip = NewZip;

                            }
                            else if (Name == (Info.Email))
                            {
                                Console.WriteLine("Enter new Email");
                                String NewEmail = Console.ReadLine();
                                Info.Email = NewEmail;

                            }


                        Console.WriteLine(" Edited ");
                        break;

                    case 4:
                        Console.WriteLine("Enter Name Which You Want To Delete");
                        string delete = Console.ReadLine();
                        AddressBook contact = null;

                        foreach (AddressBook Info in list)
                        {
                            if (Info.FirstName == delete)
                            {
                                contact = Info;
                                list.Remove(contact);
                            }
                            break;
                        }
                        Console.WriteLine(" Deleted ");
                        break;


                    case 5:
                        System.Environment.Exit(0);
                        break;
                }

            }
        }
    }
}
