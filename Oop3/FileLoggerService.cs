using System;

namespace Oop3
{
    internal class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("dosyaya loglandı");
        }
    }
}
