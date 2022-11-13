using System;

namespace arayuzler
{
    public class LogManager
    {
        public ILogge _logger;
        public LogManager(ILogge logger)
        {
            _logger = logger;
        }
        public void WriteLog()
        {
            _logger.WriteLog();
        }
    }
}