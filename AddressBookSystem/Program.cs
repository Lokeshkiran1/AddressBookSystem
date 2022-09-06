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
                Console.WriteLine("Choose option: \n1.Creating Contacts\n2.Adding New Contacts\n3.Displaying Contacts");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        UC1_AbilityToCreateContacts uC1_AbilityToCreateContacts = new UC1_AbilityToCreateContacts();
                        uC1_AbilityToCreateContacts.addContact();
                        break;
                    case 2:
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
                    case 3:
                        builder.DisplayContact();
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
