using System;

namespace  arayuzler
{
    class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Database'e log yazar");
        }
    }   
}