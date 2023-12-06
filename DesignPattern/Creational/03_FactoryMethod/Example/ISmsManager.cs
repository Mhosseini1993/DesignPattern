using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational._03_FactoryMethod.Example
{
    public interface ISmsManager
    {
        void SendMessage(MessageDto msg);
        List<MessageDto> GetMessages();
    }
}
