using System;
using System.Collections.Generic;

namespace todo
{
    public static class InputHandler
    {
        public static void Begin(List<Card> todo, List<Card> inProgress, List<Card> done)
        {
            int operationCode;
            while (true)
            {
                Console.WriteLine(Messages.Menu);
                operationCode = Int32.Parse(Console.ReadLine());
                switch (operationCode)
                {
                    case 1:
                        BoardOperations.ListBoard(todo, inProgress, done);
                        break;
                    case 2:
                        BoardOperations.AddCard(todo);
                        break;
                    case 3:
                        BoardOperations.RemoveCard(todo, inProgress, done);
                        break;
                    case 4:
                        BoardOperations.MoveCard(todo, inProgress, done);
                        break;
                    case 5:
                        return;
                }
            }
        }
    }
}