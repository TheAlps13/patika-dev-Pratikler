using System;
using System.Collections.Generic;

namespace todo
{
    public static class BoardOperations
    {


        public static void ListBoard(List<Card> todo, List<Card> inProgress, List<Card> done)
        {
            Console.WriteLine(Messages.TodoLine);
            foreach (Card card in todo) // Todo line
                card.Show();

            Console.WriteLine(Messages.InProgressLine);
            foreach (Card card in inProgress) // Inprogress line
                card.Show();
            Console.WriteLine(Messages.DoneLine);
            foreach (Card card in done) // Done line
                card.Show();


        }
        public static void AddCard(List<Card> todo)
        {
            string header, content;
            int size, appointedPersonId;

            Console.Write(Messages.EnterHeader); // Header
            header = Console.ReadLine();

            Console.Write(Messages.EnterContent); // Content
            content = Console.ReadLine();

            Console.Write(Messages.EnterSize); // Size
            size = Int32.Parse(Console.ReadLine());

            Console.Write(Messages.EnterAppointedPers); // Team member ID
            appointedPersonId = Int32.Parse(Console.ReadLine());

            todo.Add(new Card
            {
                Header = header,
                Content = content,
                Size = ((Card.CardSize)size).ToString(), // Converting enum to string
                AppointedPerson = TeamMembers.IdName[appointedPersonId]
            });

        }

        public static void RemoveCard(List<Card> todo, List<Card> inProgress, List<Card> done)
        {
            bool isAnyRemoved = false;
            // User input
            string header;
            Console.WriteLine(Messages.SelectCardToRmv);
            Console.Write(Messages.EnterCardHeader);
            header = Console.ReadLine();

            // Find the size of longest list
            int maxCount = Math.Max(Math.Max(todo.Count, inProgress.Count), done.Count);
            for (int i = 0; i < maxCount; i++)
            {
                if (i < todo.Count)
                    if (todo[i].Header.Equals(header))
                    {
                        todo.RemoveAt(i);
                        isAnyRemoved = true;
                    }

                if (i < inProgress.Count)
                    if (inProgress[i].Header.Equals(header))
                    {
                        inProgress.RemoveAt(i);
                        isAnyRemoved = true;
                    }

                if (i < done.Count)
                    if (done[i].Header.Equals(header))
                    {
                        done.RemoveAt(i);
                        isAnyRemoved = true;
                    }
            }

            if (!isAnyRemoved)
            {
                Console.WriteLine(Messages.CardNotFound);
                Console.WriteLine(Messages.EndRmv);
                Console.WriteLine(Messages.TryAgain);
                int operationCode = Int32.Parse(Console.ReadLine());
                // End removing
                if (operationCode == 1)
                    return;
                // Recursive call until something properly removed
                if (operationCode == 2)
                    RemoveCard(todo, inProgress, done);
            }
            else
                Console.WriteLine("\nKart başarıyla silindi\n");
        }

        public static void MoveCard(List<Card> todo, List<Card> inProgress, List<Card> done)
        {
            bool isAnyFound = false;
            // User input
            string header;
            Console.WriteLine(Messages.SelectCardToMove);
            Console.WriteLine(Messages.EnterCardHeader);
            header = Console.ReadLine();
            // Find the size of longest list, then loop
            int maxCount = Math.Max(Math.Max(todo.Count, inProgress.Count), done.Count);
            for (int i = 0; i < maxCount; i++)
            {
                if (i < todo.Count)
                    if (todo[i].Header.Equals(header))
                    {   // User input
                        Console.WriteLine(Messages.FoundCardInf);
                        todo[i].Show();
                        Console.WriteLine(Messages.SelectTheLineToMove);
                        int operationCode = Int32.Parse(Console.ReadLine());
                        switch (operationCode)
                        {
                            case 1:
                                Console.WriteLine("Kart zaten todo line'da ");
                                break;
                            case 2:
                                inProgress.Add(todo[i]);
                                todo.RemoveAt(i);
                                break;
                            case 3:
                                done.Add(todo[i]);
                                todo.RemoveAt(i);
                                break;
                        }
                        isAnyFound = true;
                        break;
                    }

                if (i < inProgress.Count)
                    if (inProgress[i].Header.Equals(header))
                    {
                        isAnyFound = true;
                        break;
                    }

                if (i < todo.Count)
                    if (todo[i].Header.Equals(header))
                    {
                        isAnyFound = true;
                        break;
                    }

            }
        }
    }
}