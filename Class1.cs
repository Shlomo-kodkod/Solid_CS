using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    public class SensorAnalysis : ISensorAnalysis
    {
        OxygenSensor oxygenSensor = new OxygenSensor();
        public bool IsLevelLow()
        {
            double normalLevel = 0;

            double currentlevel = oxygenSensor.GetLevel();
            return  currentlevel < normalLevel;
        }
    }
}
