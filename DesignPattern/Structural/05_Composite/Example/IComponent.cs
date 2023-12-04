using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural._05_Composite.Example
{
    public interface IComponent
    {
        string Name { get; set; }
        int Price { get; set; }
        int GetPrice();
        void Add(IComponent component);
        void Remove(IComponent component);
    }
    public class Composite : IComponent
    {
        public string Name { get; set; }
        public int Price { get; set; }
        private List<IComponent> _components = new List<IComponent>();
        public Composite(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public void Add(IComponent component)
        {
            _components.Add(component);
        }
        public void Remove(IComponent component)
        {
            _components.Remove(component);
        }
        public int GetPrice()
        {
            int totalPrice = Price;
            foreach (IComponent component in _components)
            {
                totalPrice += component.GetPrice();
            }
            Console.WriteLine($"{Name} : {totalPrice}");
            return totalPrice;
        }
    }
    public class Leaf : IComponent
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Leaf(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public int GetPrice()
        {
            Console.WriteLine($"{Name} : {Price}");
            return Price;
        }
        public void Add(IComponent component)
        {
            throw new NotImplementedException();
        }
        public void Remove(IComponent component)
        {
            throw new NotImplementedException();
        }
    }
}
