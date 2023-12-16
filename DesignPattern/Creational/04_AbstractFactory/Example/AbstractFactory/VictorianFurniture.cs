using DesignPattern.Creational._04_AbstractFactory.Example.Services.Chair;
using DesignPattern.Creational._04_AbstractFactory.Example.Services.CoffeeTable;
using DesignPattern.Creational._04_AbstractFactory.Example.Services.Sofa;

namespace DesignPattern.Creational._04_AbstractFactory.Example.AbstractFactory
{
    public class VictorianFurniture : AbstractFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new VictorianCoffeeTable();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }
}
