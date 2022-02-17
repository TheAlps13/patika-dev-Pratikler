using System;

namespace todo
{
    public class Card
    {
        private string header;
        private string content;
        private string appointedPerson;
        private string size;
        public enum CardSize { XS = 1, S, M, L, XL };
        public string Header { get => header; set => header = value; }
        public string Content { get => content; set => content = value; }
        public string AppointedPerson { get => appointedPerson; set => appointedPerson = value; }
        public string Size { get => size; set => size = value; }

        public void Show()
        {
            Console.WriteLine(Messages.Header + header);
            Console.WriteLine(Messages.Content + content);
            Console.WriteLine(Messages.AppointedPerson + appointedPerson);
            Console.WriteLine(Messages.Size + size);
            Console.WriteLine("-");
        }
    }
}