using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    public interface ILogger
    {
        void SaveLog(string logTo, string message);
    }
}
