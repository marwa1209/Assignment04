using Assignment03.interfaces.question3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03.question3Classes
{
    internal class EmailNotificationService : INotificationService
    {
        public void SendNotification(string message, string recipient)
        {
            Console.WriteLine($"Sending Email to {recipient}: {message}");
        }
    }
}
