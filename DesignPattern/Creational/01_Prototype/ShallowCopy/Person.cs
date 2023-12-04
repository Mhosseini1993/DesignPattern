using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational._01_Prototype.ShallowCopy
{
    public interface IPrototype
    {
        IPrototype Clone();
    }
    public class Person : IPrototype
    {
        public int Age { get;private set; }
        public string Name { get;private set; }
        public Person(int age,string name)
        {
            //Huge amount of configs
            Thread.Sleep(5000);
            this.Age = age; 
            this.Name = name;
        }
        public IPrototype Clone()
        {
            //MemberwiseClone is a built-in function in .Net for makeing shallow copy.
            Person cloneObject = (Person)this.MemberwiseClone();
            return (IPrototype)cloneObject;
        }
    }
}
