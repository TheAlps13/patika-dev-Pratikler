using System;

namespace arayuzler
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new();
            DatabaseLogger databaseLogger = new();
            SmsLogger smsLogger = new();

            fileLogger.WriteLog();
            databaseLogger.WriteLog();
            smsLogger.WriteLog();

            LogManager logManager = new LogManager(new SmsLogger());
            logManager.WriteLog();
        }
    }
}
