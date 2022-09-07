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
        public void EditContact(string name)
        {
            bool flag = false;
            foreach (var contactList in list)
            {
                if (contactList.firstName == name)
                {
                    flag = true;
                    Console.WriteLine("Enter your choice for the field you want to edit\n1.First Name\n2.Last Name\n3.Address\n4.city\n5.state\n6.Email\n7.PinCode\n8.Phone Number");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the new First Name : ");
                            contactList.firstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter the new Last Name :");
                            contactList.lastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter the new Address");
                            contactList.address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter the New City Name :");
                            contactList.city = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter the New State");
                            contactList.state = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter the new Email : ");
                            contactList.email = Console.ReadLine();
                            break;
                        case 7:
                            Console.WriteLine("Enter the new PinCode :");
                            contactList.pinCode = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("Enter the new Phone Number : ");
                            contactList.phoneNumber = Convert.ToInt64(Console.ReadLine());
                            break;
                    }
                }
            }
            if (flag == false)
            {
                Console.WriteLine("the given first Name Contact not exits");
            }
        }
        public void DeleteContact(string deletename)
        {
            if(list.Count>0)
            {
                foreach(var contact in list)
                {
                    if(contact.firstName==deletename)
                    {
                        list.Remove(contact);
                        Console.WriteLine("the contact deleted successfully");
                        break;
                    }
                }
                Console.WriteLine("the contact not exists");
            }
            else
            {
                Console.WriteLine("list is empty, so delete option is invalid");
            }
        }

    }
}
