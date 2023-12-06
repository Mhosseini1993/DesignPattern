using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational._03_FactoryMethod.BaseStructure
{
    public abstract class Product
    {
        public abstract void Operation();
    }
    public class ConcreteClass1 : Product
    {
        public override void Operation()
        {
            Console.WriteLine($"{nameof(Operation)} called from {nameof(ConcreteClass1)}");
        }
    }
    public class ConcreteClass2 : Product
    {
        public override void Operation()
        {
            Console.WriteLine($"{nameof(Operation)} called from {nameof(ConcreteClass2)}");
        }
    }
    public class DefaultConcreteClass : Product
    {
        public override void Operation()
        {
            Console.WriteLine($"{nameof(Operation)} called from {nameof(DefaultConcreteClass)}");
        }
    }

    public abstract class Creator
    {
        public abstract Product FactoryMethod(string config);
    }
    public class ConcreteCreator : Creator
    {
        public override Product FactoryMethod(string config)
        {
            Product product;
            product=config switch
            {
                "1" => new ConcreteClass1(),
                "2" => new ConcreteClass2(),
                _ => new DefaultConcreteClass(),
            };
            return product;
        }
    }
}
