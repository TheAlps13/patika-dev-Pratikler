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
                    Console.WriteLine(Messages.ErrMissingInfo);
                }
            }
            Console.WriteLine(Messages.AddSuccess);
        }

        public static void RemoveContact(List<Contact> contacts)
        {
            string nameOrSurname;
            int operationNumb;
            // If we get an empty string, give a warning and re-run this bloc of code
            while (true)
            {
                try
                {
                    Console.Write(Messages.EnterNameOrSurnameToRmv);
                    nameOrSurname = Console.ReadLine();

                    if (String.IsNullOrEmpty(nameOrSurname))
                        throw new ArgumentNullException();

                    foreach (Contact contact in contacts)
                    {
                        if (contact.Name.Equals(nameOrSurname) || contact.Surname.Equals(nameOrSurname))
                        {
                            contacts.Remove(contact);
                            Console.WriteLine(Messages.RmvSuccess);
                            return;
                        }
                    }

                    while (true)
                    {
                        Console.WriteLine(Messages.NotFound + "\n" + Messages.EndRemove + "\n" + Messages.TryAgain);
                        try
                        {
                            operationNumb = Int32.Parse(Console.ReadLine());
                            if (operationNumb < 1 || operationNumb > 2)
                                throw new Exception();

                            if (operationNumb == 1)
                                return; // End removing
                            if (operationNumb == 2)
                                break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine(Messages.SelectionError);
                        }
                    }
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine(Messages.EmptyFieldErr);
                }
            }
        }

        public static void UpdateContact(List<Contact> contacts) // Only updates phone number
        {
            string nameOrSurname, phoneNumb;
            int operationNumb;
            while (true)
            {
                try
                {
                    Console.Write(Messages.EnterNameOrSurnameToUpdate);
                    nameOrSurname = Console.ReadLine();

                    Console.Write(Messages.EnterPhoneNmb);
                    phoneNumb = Console.ReadLine();

                    if (String.IsNullOrEmpty(nameOrSurname) || String.IsNullOrEmpty(phoneNumb))
                        throw new ArgumentNullException();

                    for (int i = 0; i < contacts.Count; i++)
                    {
                        if (contacts[i].Name.Equals(nameOrSurname) || contacts[i].Surname.Equals(nameOrSurname))
                        {
                            contacts[i].PhoneNumber = phoneNumb;
                            Console.WriteLine(Messages.UpdateSuccess);
                            return;
                        }
                    }

                    while (true)
                    {
                        Console.WriteLine(Messages.NotFound + "\n" + Messages.EndUpdate + "\n" + Messages.TryAgain);
                        try
                        {
                            operationNumb = Int32.Parse(Console.ReadLine());
                            if (operationNumb < 1 || operationNumb > 2)
                                throw new Exception();

                            if (operationNumb == 1)
                                return; // End removing
                            if (operationNumb == 2)
                                break;

                        }
                        catch (Exception)
                        {
                            Console.WriteLine(Messages.SelectionError);
                        }
                    }
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine(Messages.EmptyFieldErr);
                }
            }
        }

        public static void ListContacts(List<Contact> contacts)
        {
            if (contacts.Count != 0)
            {
                Console.WriteLine(Messages.ContactList);
                foreach (Contact contact in contacts)
                {
                    contact.Show();
                }
            }
            else
                Console.WriteLine(Messages.NothingToShow);
        }

        public static void SearchContact(List<Contact> contacts)
        {
            int operationNumb;
            string nameOrSurname, phoneNumb;
            bool isAnyFound;
            while (true)
            {
                isAnyFound = false;
                while (true)
                {
                    Console.WriteLine(Messages.SearchType);
                    try
                    {
                        operationNumb = Int32.Parse(Console.ReadLine());
                        if (operationNumb < 1 || operationNumb > 2)
                            throw new Exception();

                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(Messages.SelectionError);
                    }
                }
                try
                {

                    if (operationNumb == 1)
                    {
                        Console.Write(Messages.EnterNameOrSurnameToSearch);
                        nameOrSurname = Console.ReadLine();
                        if (String.IsNullOrEmpty(nameOrSurname))
                            throw new ArgumentNullException();

                        Console.WriteLine(Messages.SearchResult);
                        foreach (Contact contact in contacts)
                        {
                            if (contact.Name.Equals(nameOrSurname) || contact.Surname.Equals(nameOrSurname))
                            {
                                contact.Show();
                                isAnyFound = true;
                            }
                        }
                    }
                    if (operationNumb == 2)
                    {
                        Console.Write(Messages.EnterPhoneNmb);
                        phoneNumb = Console.ReadLine();
                        if (String.IsNullOrEmpty(phoneNumb))
                            throw new ArgumentNullException();

                        Console.WriteLine(Messages.SearchResult);
                        foreach (Contact contact in contacts)
                        {
                            if (contact.PhoneNumber.Equals(phoneNumb))
                            {
                                contact.Show();
                                isAnyFound = true;
                            }
                        }
                    }

                    if (isAnyFound)
                        return;

                    while (true)
                    {
                        Console.WriteLine(Messages.NotFound + "\n" + Messages.EndSearch + "\n" + Messages.TryAgain);
                        try
                        {
                            operationNumb = Int32.Parse(Console.ReadLine());
                            if (operationNumb < 1 || operationNumb > 2)
                                throw new Exception();

                            if (operationNumb == 1)
                                return; // End removing
                            if (operationNumb == 2)
                                break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine(Messages.SelectionError);
                        }
                    }
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine(Messages.EmptyFieldErr);
                }
            }
        }
    }
}