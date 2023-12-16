using DesignPattern.Creational._03_FactoryMethod.BaseStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational._05_Builder.BaseStructure
{
    public class Product
    {
        public string Part1 { get; set; }
        public string Part2 { get; set; }
        public string Name { get; private set; }
        public Product(string name)
        {
            Name = name;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Product Name : {Name}");
            Console.WriteLine($"Product Part1 : {Part1}");
            Console.WriteLine($"Product Part2 : {Part2}");
        }
    }

    public abstract class Builder
    {
        protected Product _product;
      
        public abstract void BuildPart1();
        public abstract void BuildPart2();
        public virtual Product GetProduct()
        {
            return _product;
        }
    }
    public class ConcreteBuilder1 : Builder
    {
        public ConcreteBuilder1()
        {
            _product=new Product("Product 1");
        }
        public override void BuildPart1()
        {
            base._product.Part1="Part1_A";
        }

        public override void BuildPart2()
        {
            base._product.Part2="Part2_B";
        }
    }
    public class ConcreteBuilder2 : Builder
    {
        public ConcreteBuilder2()
        {
            _product=new Product("Product 2");
        }
        public override void BuildPart1()
        {
            base._product.Part1="Part1_C";
        }

        public override void BuildPart2()
        {
            base._product.Part2="Part2_D";
        }
    }

    public class Director
    {
        private Builder _builder;
        public void SetBuilder(Builder builder)
        {
            _builder=builder;
        }
        public void Construct()
        {
            _builder.BuildPart1();
            _builder.BuildPart2();
        }
    }
}
