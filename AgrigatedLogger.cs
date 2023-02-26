using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AgrigatedLogger : ILogger
    {
        private readonly ILogger[] _loggers;
        public AgrigatedLogger(params ILogger[] loggers)
        {
            _loggers = loggers;                
        }

        public void Log(string message)
        {
            foreach(var logger in _loggers) 
            {
               logger.Log(message);
            }
        }
    }
}
