using System;

namespace arayuzler
{
    public class SmsLogger:ILogge
    {
        public void WriteLog()
        {
            Console.WriteLine("dosyaya sms yazar");
        }
    }
}