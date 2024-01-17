using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral._04_Command.BaseStructure
{
    public class Reciver
    {
        /// <summary>
        /// default function name
        /// </summary>
        public void Action()
        {
            Console.WriteLine("Reciver.Action() Run....");
        }
    }
}
