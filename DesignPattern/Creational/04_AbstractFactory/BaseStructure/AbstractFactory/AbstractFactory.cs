using DesignPattern.Creational._04_AbstractFactory.BaseStructure.Services.ProductA;
using DesignPattern.Creational._04_AbstractFactory.BaseStructure.Services.ProductB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational._04_AbstractFactory.BaseStructure.AbstractFactory
{



    public interface IAbstractFactory
    {
        //for reach product we have to write a function and concrete class,
        //because we have just two product such as (IProductA,IProductB),
        //we wrote two functions and two concrete class
        public IProductA ConcreteProductA();
        public IProductB ConcreteProductB();
    }
    public class Factory1 : IAbstractFactory
    {
        public IProductA ConcreteProductA()
        {
            return new ConcreteProductA1();
        }
        public IProductB ConcreteProductB()
        {
            return new ConcreteProductB1();
        }
    }
    public class Factory2 : IAbstractFactory
    {
        public IProductA ConcreteProductA()
        {
            return new ConcreteProductA2();
        }

        public IProductB ConcreteProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
