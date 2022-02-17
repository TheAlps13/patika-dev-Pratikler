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
                try
                {
                    operationCode = Int32.Parse(Console.ReadLine());
                    switch (operationCode)
                    {
                        case 1:
                            BoardOperations.ListBoard(todo, inProgress, done);
                            break;
                        case 2:
                            try
                            {
                                BoardOperations.AddCard(todo);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine(Messages.IDNotFound);
                            }
                            break;
                        case 3:
                            BoardOperations.RemoveCard(todo, inProgress, done);
                            break;
                        case 4:
                            try
                            {
                                BoardOperations.MoveCard(todo, inProgress, done);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine(Messages.SelectionErr);
                            }
                            break;
                        case 5:
                            return;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine(Messages.SelectionErr);
                }

            }
        }
    }
}