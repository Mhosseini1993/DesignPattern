using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral._04_Command.BaseStructure.WithInterface
{
    public class Reciver
    {
        public void Action()
        {
            Console.WriteLine("Reciver.Action run....");
        }
    }
}
