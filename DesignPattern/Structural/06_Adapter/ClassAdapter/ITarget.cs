using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural._06_Adapter.ClassAdapter
{
    public interface ITarget
    {
        void Operation();
    }
    public class Adaptee
    {
        public void SpecificOperation()
        {
            Console.WriteLine($"{nameof(SpecificOperation)}run from {nameof(Adaptee)} class");
        }
    }
    public class Adapter : Adaptee, ITarget
    {
        public void Operation()
        {
            base.SpecificOperation();
        }
    }
}
