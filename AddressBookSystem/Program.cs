﻿using System;
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
            Console.WriteLine("Welcome To Address Book System");
            Console.WriteLine("Choose option: \n1.Creating Contacts");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                    UC_AbilityToCreateContacts uC_AbilityToCreateContacts = new UC_AbilityToCreateContacts();
                    uC_AbilityToCreateContacts.addContact();
                    break;
                default:
                    Console.WriteLine("Please enter correct option");
                    break;
            }
        }
    }
}