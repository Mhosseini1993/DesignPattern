using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural._03_Bridge.Example
{
    public interface IMailServiceBridge
    {
        void SendMessage(string subject, string message, string to);
    }

    public class GmailService : IMailServiceBridge
    {
        public void SendMessage(string subject, string message, string to)
        {
            Console.WriteLine($"{message} Send to {to} with subject {subject} with {nameof(YahooService)}");
        }
    }

    public class YahooService : IMailServiceBridge
    {
        public void SendMessage(string subject, string message, string to)
        {
            Console.WriteLine($"{message} Send to {to} with subject {subject} with {nameof(YahooService)}");
        }
    }

    public class SmsService : IMailServiceBridge
    {
        public void SendMessage(string subject, string message, string to)
        {
            Console.WriteLine($"{message} Send to {to} with subject {subject} with {nameof(SmsService)}");
        }
    }
}
