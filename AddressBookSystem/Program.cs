using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBookBuilder builder = new AddressBookBuilder();
            Console.WriteLine("Welcome To Address Book System");
            int option1;
            string bookName = "default";
            AddressBookBuilder addressBook = new AddressBookBuilder();

            Console.WriteLine("1. Would you like to work on existing addressbook ? if yes press 1");
            Console.WriteLine("2. Would you like to add  new addressbook ? if yes press 2");
            option1 = Convert.ToInt32(Console.ReadLine());
            switch (option1)
            {
                case 1:
                    addressBook.AddAddressBook(bookName);
                    break;
                case 2:
                    Console.WriteLine("Enter Name Of New Addressbook You want to create : ");
                    bookName = Console.ReadLine();
                    addressBook.AddAddressBook(bookName);
                    break;
            }

            do
            {
                Console.WriteLine("Choose option: \n1.Creating or Adding new Contacts\n2.Displaying Contacts\n" +
                    "3.Edit the Contact Details using First Name\n4.Delete the existing contact\n" +
                    "5.Ability to add multiple persons to address book\n6.Refactor to add multiple Address Book to the System\n" +
                    "");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                   /* case 1:
                        UC1_AbilityToCreateContacts uC1_AbilityToCreateContacts = new UC1_AbilityToCreateContacts();
                        uC1_AbilityToCreateContacts.addContact();
                        break;*/
                    case 1:
                        Console.WriteLine("Enter First Name :");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name :");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("Enter Address :");
                        string address = Console.ReadLine();
                        Console.WriteLine("Enter City :");
                        string city = Console.ReadLine();
                        Console.WriteLine("Enter State :");
                        string state = Console.ReadLine();
                        Console.WriteLine("Enter Email :");
                        string email = Console.ReadLine();
                        Console.WriteLine("Enter pinCode :");
                        int pinCode = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Phone Number :");
                        long phoneNumber = Convert.ToInt64(Console.ReadLine());
                        builder.AddContact(firstName, lastName, address, city, state, email, pinCode, phoneNumber);
                        break;
                    case 2:
                        builder.DisplayContact();
                        break;
                    case 3:
                        Console.WriteLine("Enter the first name of the contact");
                        string nameToEdit=Console.ReadLine();
                        builder.EditContact(nameToEdit);
                        break;
                    case 4:
                        Console.WriteLine("Enter the first name of the contact you want to delete details");
                        string nameToDelete=Console.ReadLine();
                        builder.DeleteContact(nameToDelete);
                        break;

                    case 5:
                        Console.WriteLine("Enter Name For New AddressBook");
                        string newAddressBook = Console.ReadLine();
                        addressBook.AddAddressBook(newAddressBook);
                        Console.WriteLine("Would you like to Switch to " + newAddressBook);
                        Console.WriteLine("1.Yes \n2.No");
                        int c = Convert.ToInt32(Console.ReadLine());
                        if (c == 1)
                        {
                            bookName = newAddressBook;
                        }
                        break;


                    case 6:
                        Console.WriteLine("Enter Name Of AddressBook From Below List");
                        foreach (KeyValuePair<string, AddressBookBuilder> item in addressBook.GetAddressBook())
                        {
                            Console.WriteLine(item.Key);
                        }
                        while (true)
                        {
                            bookName = Console.ReadLine();
                            if (addressBook.GetAddressBook().ContainsKey(bookName))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("No such AddressBook found. Try Again.");
                            }
                        }
                        break;


                    default:
                        Console.WriteLine("Please enter correct option");
                        break;
                }
                Console.WriteLine("Do you want to continue, then press '1' else press '0' to exit");
                option1 = Convert.ToInt32(Console.ReadLine());
            }
            while (option1 != 0);
        }
    }
}
