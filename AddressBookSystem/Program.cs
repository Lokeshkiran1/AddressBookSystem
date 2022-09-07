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
            int option2;

            do
            {
                Console.WriteLine("Choose option: \n1.Creating or Adding new Contacts\n2.Displaying Contacts\n3.Edit the Contact Details using First Name\n4.Delete the existing contact");
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
                    default:
                        Console.WriteLine("Please enter correct option");
                        break;
                }
                Console.WriteLine("Do you want to continue, then press '1' else press '0' to exit");
                option2 = Convert.ToInt32(Console.ReadLine());
            }
            while (option2 != 0);
        }
    }
}
