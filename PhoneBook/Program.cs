using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome To PhoneBook Application");
            bool option = true;
            List<Contact> contacts = new List<Contact>();
            while(option)
            {
                WriteLine("*********************************************");
                WriteLine("Choose One Option From Below:");
                WriteLine("*********************************************");
                WriteLine("Press 1 To Add Contact");
                WriteLine("Press 2 To Display A Contact By Number");
                WriteLine("Press 3 To View All Contacts");
                WriteLine("Press 4 To Search for a given Name");
                WriteLine("Press 5 To Exit");
                int t = Convert.ToInt32(ReadLine());
                if(t == 1)
                {
                    Add add = new Add();
                    add.addValue(contacts);
                } 
                if(t == 2)
                {
                    Display display = new Display();
                    if(contacts.Count == 0) { WriteLine("No Contact To be Displayed"); }
                    else
                    display.displayContact(contacts);
                }
                if(t == 3)
                {
                    View contact = new View();
                    if (contacts.Count == 0) { WriteLine("No Contact To be Viewed"); }
                    else
                        contact.Display(contacts);
                }
                if(t == 4)
                {
                    WriteLine("Enter Name Whose Contact You Want To Search");
                    Search search = new Search();
                    search.display(contacts,ReadLine());

                }
                if(t == 5)
                {
                    option = false;
                }
                WriteLine("\n\n\n");
            }
            WriteLine("Thankyou For Using Us");
        }
    }
}
