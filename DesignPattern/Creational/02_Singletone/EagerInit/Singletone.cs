using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational._02_Singletone.EagerInit
{
    public class Singletone
    {
        private static readonly Singletone _instance = new Singletone();
        private Singletone()
        {
        }
        public static Singletone Instance() => _instance;
    }
}
