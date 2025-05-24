using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplePractice.DependencyInversion.Violate
{

    public class EmailSender
    {
        public void SendEMail(string message)
        {
            Console.WriteLine("Sending message: " + message);
        }
    }

    internal class NotificationService
    {
        private readonly EmailSender _sender = new EmailSender();

        public void Notify(string message)
        {
            _sender.SendEMail(message);
        }


    }
}
