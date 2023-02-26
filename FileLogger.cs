using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FileLogger :ILogger
    {
        private readonly string path = "C:\\temp\\testlog.txt";
        public void Log(string log) 
        {
            File.AppendAllText(path, log + Environment.NewLine);

        }
    }
}
