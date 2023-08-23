using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace PhoneBook
{
    internal class Search
    {
        internal void display(List<Contact> contacts, string v)
        {
            bool flag = false;
            for (int i = 0; i < contacts.Count; i++)
            {
                Contact contact = contacts[i];
                if(contact.Name == v)
                {
                    flag= true;
                    WriteLine($"Contact {contact.Name}'s Phone Number is {contact.number}");
                }
            }
            if (!flag)
                WriteLine("No Contact Found");
        }
    }
}
