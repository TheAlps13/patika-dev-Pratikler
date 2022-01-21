using System;
using System.Collections.Generic;

namespace contacts
{
    internal static class ContactOperations
    {
        public static void AddContact(List<Contact> contacts)
        {
            string name, surname, phoneNumber;
            while (true)
            {
                try
                {
                    Console.Write(Messages.EnterName);
                    name = Console.ReadLine();

                    Console.Write(Messages.EnterSurname);
                    surname = Console.ReadLine();

                    Console.Write(Messages.EnterPhoneNmb);
                    phoneNumber = Console.ReadLine();

                    contacts.Add(new Contact()
                    {
                        Name = name,
                        Surname = surname,
                        PhoneNumber = phoneNumber
                    });
                    // If reaching  here without throwing any error, break the loop
                    break;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Hata ! Herhangi bir değeri eksik girdiniz, tekrar deneyiniz");
                }
            }
        }

        public static bool RemoveNumb(List<Contact> contacts)
        {
            string nameOrSurname;

            // If we get an empty string, give a warning and re-run this bloc of code
                retry:
                {
                    Console.Write(Messages.EnterNameOrSurnameToRmv);
                    nameOrSurname = Console.ReadLine();
                }
                // Empty string check
                if(String.IsNullOrEmpty(nameOrSurname))
                {
                    Console.WriteLine("Hata ! Bilgiler boş bırakılamaz");
                    goto retry; // Go back till something properly entered
                }

                foreach (Contact contact in contacts)
                {
                    if(contact.Name.Equals(nameOrSurname) || contact.Surname.Equals(nameOrSurname))
                    {
                        contacts.Remove(contact);
                        return true;
                    }
                }

                
                return false;
        }


    }
}