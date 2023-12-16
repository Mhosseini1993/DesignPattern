using DesignPattern.Creational._04_AbstractFactory.Example.Services.Chair;
using DesignPattern.Creational._04_AbstractFactory.Example.Services.CoffeeTable;
using DesignPattern.Creational._04_AbstractFactory.Example.Services.Sofa;

namespace DesignPattern.Creational._04_AbstractFactory.Example.AbstractFactory
{
    public class ModernFurniture : AbstractFurnitureFactory
    {
        public IChair CreateChair()
        {
          return new ModernChair();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new ModernCoffeeTable();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
