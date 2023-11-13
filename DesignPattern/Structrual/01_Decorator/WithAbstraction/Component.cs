using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structrual._01_Decorator.WithAbstraction
{
    public abstract class Component
    {
        public abstract void Operation();
    }
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine($"{nameof(Operation)} from {nameof(ConcreteComponent)} called");
        }
    }

    public abstract class Decorator : Component
    {
        private readonly Component _com;

        public Decorator(Component component)
        {
            this._com=component;
        }
        public override void Operation()
        {
            _com.Operation();
        }
    }
    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(Component component) : base(component)
        {

        }
        public override void Operation()
        {
            base.Operation();
            //Add New Feature before or after calling operation
            NewFeature();
        }
        private void NewFeature()
        {
            Console.WriteLine("New Feature Added to class");
        }
    }

}
