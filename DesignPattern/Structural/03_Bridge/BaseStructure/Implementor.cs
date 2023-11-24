using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural._03_Bridge.BaseStructure
{
    public abstract class Implementor
    {
        public abstract void Implementation();
    }
    public class ConcreteImplementor : Implementor
    {
        public override void Implementation()
        {
            Console.WriteLine("Run... ConcreteImplementor.Implementation()...");
        }
    }

    public abstract class Abstraction
    {
        private readonly Implementor implementor;
        public Abstraction()
        {
            implementor=new ConcreteImplementor();
        }

        public virtual void Function()
        {
            implementor.Implementation();
        }

    }
    public class RefinedAbstraction : Abstraction
    {
    }
}
