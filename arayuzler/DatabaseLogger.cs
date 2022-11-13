using System;

namespace arayuzler
{
    public class DatabaseLogger:ILogge
    {
        public void WriteLog()
        {
            Console.WriteLine("dosyaya database yazar");
        }
    }
}