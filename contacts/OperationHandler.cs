using System;

namespace contacts
{
    static class OperationHandler
    {

        public static void Operate(int operationCode)
        {
            switch (operationCode)
            {
                case 1:
                    ContactOperations.AddContact();
            }
        }
    }
}