using AddressBookProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddreessBook
{
    internal class AddressBook
    {
        List<ContactDetails> add = new List<ContactDetails>();
        public void Details()
        {
            ContactDetails contactDetails = new ContactDetails();
            Console.WriteLine("Enter the first name");
            contactDetails.fname = Console.ReadLine();
            Console.WriteLine("Enter the last name");
            contactDetails.lname = Console.ReadLine();
            Console.WriteLine("Enter the address");
            contactDetails.address = Console.ReadLine();
            Console.WriteLine("Enter the City");
            contactDetails.city = Console.ReadLine();
            Console.WriteLine("Enter the state");
            contactDetails.state = Console.ReadLine();
            Console.WriteLine("Enter the zipCode");
            contactDetails.zipcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the PhoneNumber");
            contactDetails.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the email");
            contactDetails.email = Console.ReadLine();

            add.Add(contactDetails);
        }
        //public void Display()  //UC2
        //{
        //    foreach(ContactDetails contactDetails in add)
        //    {
        //        Console.WriteLine("\nFirstName: "+contactDetails.fname);
        //        Console.WriteLine("LastName: " +contactDetails.lname);
        //        Console.WriteLine("Address " + contactDetails.address);
        //        Console.WriteLine("City :" + contactDetails.city);
        //        Console.WriteLine("State:"+contactDetails.state);
        //        Console.WriteLine("ZipCode:"+contactDetails.zipcode);
        //        Console.WriteLine("PhoneNumber: " + contactDetails.PhoneNumber);
        //        Console.WriteLine("Email: " + contactDetails.email);
        //    }
        //}
    }
}