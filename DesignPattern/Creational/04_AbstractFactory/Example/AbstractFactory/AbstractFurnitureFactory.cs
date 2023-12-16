using DesignPattern.Creational._04_AbstractFactory.Example.Services.Chair;
using DesignPattern.Creational._04_AbstractFactory.Example.Services.CoffeeTable;
using DesignPattern.Creational._04_AbstractFactory.Example.Services.Sofa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational._04_AbstractFactory.Example.AbstractFactory
{
    public interface AbstractFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
        ICoffeeTable CreateCoffeeTable();
    }
}
