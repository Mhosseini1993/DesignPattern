using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral._02_TemplateMethod.Example
{
    public abstract class AbstractRegisterOrder
    {
        public void Execute(string from, string to, string message)
        {
            this.RegisterOrder();
            this.SaveDataInDb();
            this.ChnageStockCount();
            this.SendNotification(from, to, message);
        }
        protected void RegisterOrder()
        {
            Console.WriteLine("Order Registered ...");
        }
        protected void SaveDataInDb()
        {
            Console.WriteLine("Data saved in SQL");
        }
        protected void ChnageStockCount()
        {
            Console.WriteLine("Stock count decrease ...");
        }
        protected abstract void SendNotification(string from, string to, string message);
    }
    public class EmailSendNotification : AbstractRegisterOrder
    {
        protected override void SendNotification(string from, string to, string message)
        {
            Console.WriteLine($"Message {message} from {from} send to {to} with email");
        }
    }
    public class SmsSendNotification : AbstractRegisterOrder
    {
        protected override void SendNotification(string from, string to, string message)
        {
            Console.WriteLine($"Message {message} from {from} send to {to} with SMS");
        }
    }
    public class Client
    {
        public static void Run(AbstractRegisterOrder order)
        {
            order.Execute("mhosseinisru@gmail.com", "test", "Hello word");
        }
    }
}
