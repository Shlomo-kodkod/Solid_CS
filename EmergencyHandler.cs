using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Solid_Principle
{
    internal class EmergencyHandler
    {
        Email email = new Email();
        public void EmergencyShutdown()
        {
            Console.WriteLine("Emergency shutdown triggered!");
            File.WriteAllText("log.txt", "EMERGENCY OCCURRED");
            email.SendEmail("admin@spaceagency.com", "Emergency triggered");
        }
    }
}
