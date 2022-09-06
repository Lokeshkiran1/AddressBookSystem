using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBookBuilder
    {
        private LinkedList<Contacts> list = new LinkedList<Contacts>();
        public void AddContact(string firstName, string lastName, string address, string city, string state, string email, int pinCode, long phoneNumber)
        {
           Contacts contacts = new Contacts();
            contacts.firstName=firstName;
            contacts.lastName=lastName;
            contacts.address=address;   
            contacts.city=city;
            contacts.state=state;
            contacts.email=email;
            contacts.pinCode=pinCode;
            contacts.phoneNumber=phoneNumber;
            list.AddLast(contacts);
        }
        public void DisplayContact()
        {
            if(list.Count > 0)
            {
                foreach(var contact in list)
                {
                    Console.WriteLine("First Name : " + contact.firstName);
                    Console.WriteLine("Last Name : " + contact.lastName);
                    Console.WriteLine("Address : " + contact.address);
                    Console.WriteLine("City : " + contact.city);
                    Console.WriteLine("State : " + contact.state);
                    Console.WriteLine("Email : " + contact.email);
                    Console.WriteLine("Zip : " + contact.pinCode);
                    Console.WriteLine("Phone Number : " + contact.phoneNumber + "\n");
                }
            }
            else
                Console.WriteLine("list is empty");
        }

    }
}
