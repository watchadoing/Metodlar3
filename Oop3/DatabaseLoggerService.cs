using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    internal class DatabaseLoggerService:ILoggerService
    {
        public void Log() 
        {
            Console.WriteLine("veri tabanına loglandı");
        }
    }
}
