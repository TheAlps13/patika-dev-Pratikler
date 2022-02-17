using System;
using System.Collections.Generic;

namespace todo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> todo = new List<Card>(InitialCards.ToDo);
            List<Card> inProgress = new List<Card>(InitialCards.InProgress);
            List<Card> done = new List<Card>(InitialCards.Done);
            
            InputHandler.Begin(todo, inProgress, done);
        }
    }
}
