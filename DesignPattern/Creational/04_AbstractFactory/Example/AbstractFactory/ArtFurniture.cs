using DesignPattern.Creational._04_AbstractFactory.Example.Services.Chair;
using DesignPattern.Creational._04_AbstractFactory.Example.Services.CoffeeTable;
using DesignPattern.Creational._04_AbstractFactory.Example.Services.Sofa;

namespace DesignPattern.Creational._04_AbstractFactory.Example.AbstractFactory
{
    public class ArtFurniture : AbstractFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ArtChair();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new ArtCoffeeTable();
        }

        public ISofa CreateSofa()
        {
            return new ArtSofa();
        }
    }
}
