namespace contacts
{
    class Contact
    {
        private string name;
        private string surname;
        private string phoneNumber;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}