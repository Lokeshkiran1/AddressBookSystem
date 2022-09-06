using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class UC1_AbilityToCreateContacts
    {
        static string firstName, lastName, address, city, state, email;
        static int pinCode;
        static long phoneNumber;
        public void addContact()
        {
            Console.WriteLine("Add first name : ");
            firstName = Console.ReadLine();
            Console.WriteLine("Add last name : ");
            lastName = Console.ReadLine();
            Console.WriteLine("Add address : ");
            address= Console.ReadLine();
            Console.WriteLine("Add city : ");
            city= Console.ReadLine();
            Console.WriteLine("Add state : ");
            state= Console.ReadLine();
            Console.WriteLine("Add email : ");
            email= Console.ReadLine();
            Console.WriteLine("Add pin code : ");
            pinCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add phone number : ");
            phoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Name : "+firstName+" "+lastName+"\nAddress: "+address+"\nCity : "+city+" , state : "+state+" , PinCode : "+pinCode+"\nPhoneNumber : "+phoneNumber+"\nEmail : "+email);

        }
    }
}
