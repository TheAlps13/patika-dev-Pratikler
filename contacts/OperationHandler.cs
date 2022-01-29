using System;
using System.Collections.Generic;

namespace contacts
{
    public static class OperationHandler
    {

        public static void Start(List<Contact> contacts)
        {
            int operationCode = 0;
            while (true)
            {
                Console.WriteLine(Messages.SelectOperation);
                try
                {
                    operationCode = Int32.Parse(Console.ReadLine());
                    if (operationCode < 1 || operationCode > 6)
                        throw new Exception();
                }
                catch (Exception)
                {
                    Console.WriteLine(Messages.SelectionError);
                }
                switch (operationCode)
                {
                    case 1:
                        ContactOperations.AddContact(contacts);
                        break;

                    case 2:
                        ContactOperations.RemoveContact(contacts);
                        break;

                    case 3:
                        ContactOperations.UpdateContact(contacts);
                        break;

                    case 4:
                        ContactOperations.ListContacts(contacts);
                        break;

                    case 5:

                        ContactOperations.SearchContact(contacts);
                        break;

                    case 6:
                        return;
                }
            }
        }

    }
}