using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Service
    {
        private readonly ILogger _logger;
        public Service(ILogger logger)
        {
            _logger = logger;
        }

        public void DoSome() 
        {
            var currDate = DateTime.Now.ToShortDateString();
            var currTime = DateTime.Now.ToLongTimeString();

            _logger.Log("DoSome ... " + currDate + "-" + currTime);

        } 
    }
}
