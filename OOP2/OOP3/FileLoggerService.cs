using System;

namespace OOP3
{
    public partial class DatabaseLoggerService
    {
        public class FileLoggerService : ILoggerService
        {
            public void Log()
            {

                Console.WriteLine("Dosyaya loglandı");
            }


        }
    }
}
