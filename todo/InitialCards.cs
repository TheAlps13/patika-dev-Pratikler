using System.Collections.Generic;

namespace todo
{
    public static class InitialCards
    {
        public static List<Card> ToDo = new List<Card>()
        {
            new Card (){ Header = "Ekmek Alma", Content = "Fırına gidip ekmek alınması", AppointedPerson = "Alper", Size = "S" }
        };

        public static List<Card> InProgress = new List<Card>()
        {
            new Card(){ Header = "Halay Çekme", Content = "Mahmut Tuncher show'da çılgınlar gibi halay çekilmesi", AppointedPerson = "Yunus", Size= "XL" }
        };

        public static List<Card> Done = new List<Card>()
        {
            new Card() { Header = "Yılkı Atını Çağırma", Content = "Gandalf gibi ıslık çalarak yılkı atının çağırılması", AppointedPerson = "Bahri", Size = "M" }
        };

    }
}