using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class Email : IEmailAlert
    {
        public static void SendEmail(string to, string message)
        {
            Console.WriteLine($"Sending email to {to}: {message}");
        }

    }
}
