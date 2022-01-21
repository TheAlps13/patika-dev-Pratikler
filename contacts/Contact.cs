using System;

namespace contacts
{
    class Contact
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
    }
}