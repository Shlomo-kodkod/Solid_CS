using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    public class OxygenSensor : ISensor, ISensorAnalysis
    {
        public double GetLevel()
        {
            double OLevel = 30;
            return OLevel;
        }

        public bool IsLevelLow()
        {
            double normalLevel = 0;

            double currentlevel = GetLevel();
            return currentlevel < normalLevel;
        }
    }
    
    
}
