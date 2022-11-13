using System;

namespace arayuzler
{
    public class FileLogger:ILogge
    {
        public void WriteLog()
        {
            Console.WriteLine("dosyaya Logger yazar");
        }
    }
}