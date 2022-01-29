using System;
using System.Collections.Generic;

namespace contacts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>(TestContacts.InitialContacts);
            InputHandler.Start(contacts);
        }
    }
}
