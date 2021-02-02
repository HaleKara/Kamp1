using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService
    {
        public void Log(string msg)
        {
            Console.WriteLine("Dosyaya loglandı."+ msg); ;
        }
    }
}
