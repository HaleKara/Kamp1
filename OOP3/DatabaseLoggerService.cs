using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log(string msg)
        {
            Console.WriteLine("Veri Tabanına loglandı." + msg); ;
        }
    }
}
