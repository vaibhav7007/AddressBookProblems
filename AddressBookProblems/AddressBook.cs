using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AddreessBook
{
    class AddressBook
    {
        List<ContactDetails> add = new List<ContactDetails>();
        public void Details()
        {
            ContactDetails contactDetails = new ContactDetails();
            Console.WriteLine("Enter Details of person");
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
        public void Display()  //UC2
        {
            foreach (ContactDetails contactDetails in add)
            {
                Console.WriteLine("Details of person in addressbook ");
                Console.WriteLine("\nFirstName: " + contactDetails.fname);
                Console.WriteLine("LastName: " + contactDetails.lname);
                Console.WriteLine("Address " + contactDetails.address);
                Console.WriteLine("City :" + contactDetails.city);
                Console.WriteLine("State:" + contactDetails.state);
                Console.WriteLine("ZipCode:" + contactDetails.zipcode);
                Console.WriteLine("PhoneNumber: " + contactDetails.PhoneNumber);
                Console.WriteLine("Email: " + contactDetails.email);

            }
        }
        //UC3 Edit the contact
        public void Edit()
        {
            foreach (var Data in add)
            {
                if (add.Contains(Data))
                {
                    Console.WriteLine("1.FirstName:\n2.LastName:\n3.Address:\n4.City:\n5.State:\n6.ZipCode:\n7.PhoneNumber:\n8.Email");
                    Console.WriteLine("Update your option");
                    int option = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine("Select your choice");
                    switch (option)
                    {
                        case 1:
                            string firstname = Console.ReadLine();
                            Data.fname = firstname;
                            break;
                        case 2:
                            string lastname = Console.ReadLine();
                            Data.lname = lastname;
                            break;
                        case 3:
                            string Address = Console.ReadLine();
                            Data.address = Address;
                            break;
                        case 4:
                            string City = Console.ReadLine();
                            Data.city = City;
                            break;
                        case 5:
                            string State = Console.ReadLine();
                            Data.state = State;
                            break;
                        case 6:
                            long ZipCode = Convert.ToInt64(Console.ReadLine());
                            Data.zipcode = ZipCode;
                            break;
                        case 7:
                            long Phonenumber = Convert.ToInt64(Console.ReadLine());
                            Data.PhoneNumber = Phonenumber;
                            break;
                        case 8:
                            string Email = Console.ReadLine();
                            Data.email = Email;
                            break;

                    }
                    Console.WriteLine("FirstName:{0}\nLastName:{1}\nAddress:{2}\nCity:{3}\nState:{4}\nZipCode:{5}\nPhoneNumber:{6}\nEmail{7}"
                                     , Data.fname, Data.lname, Data.address, Data.city, Data.state, Data.zipcode, Data.PhoneNumber, Data.email);
                }
            }
        }

        //UC4 Deleting Contact
        public void Delete()
        {
            Console.WriteLine("Enter first name to delete");
            string firstname = Console.ReadLine();
            foreach (var Data1 in add)
            {
                if (Data1.fname == firstname)
                {
                    add.Remove(Data1);
                    Console.WriteLine("Successfully removed");
                    break;
                }
                else
                {
                    Console.WriteLine("Contact not present");
                }
            }
        }

        public void MultipleAddressBook()
        {
            int i = 1;
            Dictionary<string, List<ContactDetails>> addressdict = new Dictionary<string, List<ContactDetails>>();
            Console.WriteLine("No.of addressbook to add");
            int NoOfAddressbook = Convert.ToInt32(Console.ReadLine());
            while (i <= NoOfAddressbook)
            {
                Console.WriteLine("Enter the Name");
                string Name = Console.ReadLine();
                Details();
                //addressdict.Add(Name, add);
                addressdict.Add(Name, add);
                Console.WriteLine("\n" + Name);
                Display();
                i++;
            }
        }

        //UC7 Duplicae person searching using lambda expression
        public void DuplicateNames()
        {
            Console.WriteLine("Enter to first name to check");
            string first_Name = Console.ReadLine();

            foreach (var data in add)
            {
                if (data.fname == first_Name)
                {
                    Console.WriteLine("Contact already present");
                    break;
                }
                else
                {
                    Console.WriteLine("Entering new Contact");
                }
            }
        }
    }
}