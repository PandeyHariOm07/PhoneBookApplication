using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace PhoneBook
{
    internal class View
    {
        internal void Display(List<Contact> contacts)
        {
            for (int i = 0; i < contacts.Count; i++)
            {
                Contact contact = contacts[i];
                WriteLine($"Name: {contact.Name}");
            }
        }
    }
}
