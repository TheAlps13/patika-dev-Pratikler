using System.Collections.Generic;

namespace todo
{
    class InitialCards
    {
        List<Card> InitialCardList = new List<Card>()
        {
            new Card (){ Header = "Ekmek Alınması", Content = "Fırına gidip ekmek alınması", AppointedPerson = "Alper", Size = "S"}
        };
    }
}