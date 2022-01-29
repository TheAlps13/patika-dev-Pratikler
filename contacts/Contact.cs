using System;

namespace contacts
{
    public class Contact
    {
        private string name;
        private string surname;
        private string phoneNumber;

        public string Name
        {
            get => name;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException();

                name = value;
            }
        }
        public string Surname
        {
            get => surname;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException();

                surname = value;
            }
        }
        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException();

                phoneNumber = value;
            }
        }

        public void Show()
        {
            Console.WriteLine(Messages.Name + Name);
            Console.WriteLine(Messages.Surname + Surname);
            Console.WriteLine(Messages.PhoneNmb + PhoneNumber);
            Console.WriteLine("-");
        }
    }
}