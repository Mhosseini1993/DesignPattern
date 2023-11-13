using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structrual._01_Decorator.SimplestDecorator
{
    public class SendEmail
    {
        public void Send()
        {
            Console.WriteLine($"{nameof(Send)} called from {nameof(SendEmail)}");
        }
    }

    public  class SendEmailDecorator : SendEmail
    {
        private readonly SendEmail _obj;

        public SendEmailDecorator(SendEmail sendEmailObj)
        {
            _obj=sendEmailObj;
        }
        public void SendEmailAndSaveLog()
        {
            _obj.Send();
            SaveLog();
        }
        private void SaveLog()
        {
            System.Diagnostics.Debug.WriteLine("Log saved");
        }
    }
}
