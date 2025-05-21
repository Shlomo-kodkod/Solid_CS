using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class FileLogger : ILogger
    {
        public void SaveLog(string logTo, string message)
        {
            File.WriteAllText(logTo, message);
        }
        
    }
}

