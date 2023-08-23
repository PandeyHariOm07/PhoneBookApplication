using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace PhoneBook
{
    internal class Add
    {
        internal void addValue(List<Contact> contacts)
        {
            Contact create = new Contact();
            WriteLine("Enter Name of Contact Whom You want To Add");
            create.Name = ReadLine();
            WriteLine("Enter Number of Contact Whom You want To Add");
            create.number = Convert.ToInt32(ReadLine());
            contacts.Add(create);
        }
    }
}
