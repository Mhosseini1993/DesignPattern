using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational._02_Singletone.LazyInit
{
    public class Singletone
    {
        private static Singletone? _instance = null;
   
        private Singletone()
        {

        }
        public static Singletone Instance()
        {
            if (_instance == null)
                _instance = new Singletone();
            return _instance;
        }
    }
}
