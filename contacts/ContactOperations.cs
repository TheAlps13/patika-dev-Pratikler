using System.Collections.Generic;

namespace contacts
{
    static class ContactOperations
    {
        private static List<Contact> contactList = new List<Contact>();

        public static void AddContact(string name, string surname, string phoneNumber)
        {
            contactList.Add(new Contact()
            {
                Name = name,
                Surname = surname,
                PhoneNumber = phoneNumber
            });
        }

        public static void RemoveContact()
        {
            
        }
    }
}