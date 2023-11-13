using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structrual._01_Decorator.WithInterface
{
    public interface IComponent
    {
        void Operation();
    }
    public class ConcreteComponent : IComponent
    {
        public void Operation()
        {
            Console.WriteLine($"{nameof(Operation)} called from {nameof(ConcreteComponent)}");
        }
    }

    public abstract class Decorator : IComponent
    {
        private readonly IComponent _com;

        public Decorator(IComponent component)
        {
            this._com=component;
        }
        public virtual void Operation()
        {
            _com.Operation();
        }
    }

    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(IComponent component) : base(component)
        {

        }
        //public void DoStuff()
        //{
        //    base.Operation();
        //    NewFeature();
        //}
        public override void Operation()
        {
            base.Operation();
            NewFeature();
        }
        private void NewFeature()
        {
            Console.WriteLine("New Feature Added to class");
        }
    }
}
