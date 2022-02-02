using System.Collections.Generic;

namespace todo
{
    public static class BoardOperations
    {
      

        public static void ListBoard(List<Card> boardList)
        {
            foreach(Card card in boardList)
            {
                card.Show();
            }
        }
        public static void AddCard(List<Card> boardList, TeamMembers teamMembers)
        {
            
        }
    }
}