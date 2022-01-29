using System.Collections.Generic;

namespace contacts
{
    //This class contains five initial contacts
    class TestContacts
    {
        public static readonly List<Contact> InitialContacts = new List<Contact>()
        {
            new Contact(){Name = "Alper", Surname = "Taşçı", PhoneNumber = "05000000000000"},
            new Contact(){Name = "Yunus", Surname = "Gülaslan", PhoneNumber = "06000000000"},
            new Contact(){Name = "Bahri", Surname = "Karabal", PhoneNumber = "07000000000"},
            new Contact(){Name = "Necati", Surname = "İşlemez", PhoneNumber = "08000000000"},
            new Contact(){Name = "İbrahim", Surname = "Halıçırpan", PhoneNumber = "09000000000"}
        };
    }
}