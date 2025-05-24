using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplePractice.DependencyInversion.Correct
{

    public interface IMessageSender
    {
        void SendMessage(string message);
    }


    public class EmailSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Sending EMail: " + message);
        }
    }

    public class SMSSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Sending SMS: " + message);
        }
    }


    public class NotificationService
    {
        private readonly IMessageSender _sender;

        public NotificationService(IMessageSender sender)
        {
            _sender = sender;
        }

        public void Notify(string message)
        {
            _sender.SendMessage(message);
        }

    }
}
