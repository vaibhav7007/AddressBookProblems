using System;

namespace AddreessBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the addressbook problems");
            AddressBook addressBook = new AddressBook();
            while (true)
            {
                Console.WriteLine("Choose the option from below");
                Console.WriteLine("\n1.Add\n2.Display\n3.Edit\n4.Delete\n5.AddressBook\n6.Duplicate Person");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressBook.Details(); //UC1
                        break;
                    case 2:
                        addressBook.Display(); //UC2
                        break;
                    case 3:
                        addressBook.Edit();//UC3
                        break;
                    case 4:
                        addressBook.Delete();//UC4
                        break;
                    case 5:
                        addressBook.MultipleAddressBook();//UC6
                        break;
                    case 6:
                        addressBook.DuplicateNames();//UC7
                        break;
                }
            }
        }
    }
}