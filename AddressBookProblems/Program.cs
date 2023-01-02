using System;

namespace AddreessBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the addressbook problems");
            AddressBook addressBook = new AddressBook();
            addressBook.Details(); //UC1
            addressBook.Display(); //UC2
            addressBook.Edit();//UC3
        }
    }
}