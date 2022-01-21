using System;
using System.Collections.Generic;

namespace contacts
{
    class Program
    {
        static void Main(string[] args)
        {

            int operationNumb = 0;
            List<Contact> contacts = new List<Contact>();
            int i = 4;
            while (i > 0)
            {
                Console.WriteLine(Messages.SelectOperation);
                try
                {
                    operationNumb = Int32.Parse(Console.ReadLine());
                    if (operationNumb < 1 || operationNumb > 5)
                        throw new Exception();
                }
                catch (Exception)
                {
                    Console.WriteLine(Messages.SelectionError);
                }
                switch (operationNumb)
                {
                    case 1:
                        ContactOperations.AddContact(contacts);
                        break;

                    case 2:
                        while (true)
                        {
                            if (!ContactOperations.RemoveNumb(contacts))
                            {
                                Console.WriteLine(Messages.NotFound + "\n" + Messages.EndRemove + "\n" + Messages.TryAgain);
                                try
                                {
                                    operationNumb = Int32.Parse(Console.ReadLine());
                                    if (operationNumb < 1 || operationNumb > 2)
                                        throw new Exception();
                                    else
                                        if (operationNumb == 1)
                                        break; // End removing

                                }
                                catch (Exception)
                                {
                                    Console.WriteLine(Messages.SelectionError);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Numara silme işlemi başarıyla gerçekleşti" + "\n");
                                break;
                            }
                        }
                        break;
                }

                i--;
            }

            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact.Name);
                Console.WriteLine(contact.Surname);
                Console.WriteLine(contact.PhoneNumber);
            }

        }


    }
}
