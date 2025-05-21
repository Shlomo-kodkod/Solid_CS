using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class DatabaseLogger : ILogger
    {
        public void SaveLog(string logTo, string message)
        {
            Console.WriteLine($"save log to {logTo}");
        }
}
}
