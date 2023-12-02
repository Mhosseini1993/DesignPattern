using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural._06_Adapter.ObjectAdapter
{
    public abstract class Target
    {
        public abstract void Operation();
    }
    public class Adaptee
    {
        public void SpecificOperation()
        {
            Console.WriteLine($"{nameof(SpecificOperation)}run from {nameof(Adaptee)} class");
        }
    }
    public class Adapter : Target
    {
        private Adaptee obj;
        public Adapter()
        {
            obj = new Adaptee();    
        }
        public override void Operation()
        {
            obj.SpecificOperation();
        }
    }
}
