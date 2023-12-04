using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational._01_Prototype.DeepCopy
{

    public interface IPrototype
    {
        IPrototype Clone();
    }
    public class Car : IPrototype
    {
        public string Brand { get; set; }
        public Wheel _wheel;
        public Car(string brand,Wheel wheel)
        {
            //huge mount of config
            Thread.Sleep(5000);
            this.Brand = brand;
            _wheel = wheel;
        }
        public IPrototype Clone()
        {
            Car finalClone =(Car) this.MemberwiseClone();
            finalClone._wheel=(Wheel)finalClone._wheel.Clone();
            return (IPrototype)finalClone;
        }
    }
    public class Wheel : IPrototype
    {
        public string Material { get; set; }

        public Wheel(string material)
        {
            this.Material = material;
        }
        public IPrototype Clone()
        {
            Wheel cloneObject = (Wheel)this.MemberwiseClone();
            return (IPrototype)cloneObject;
        }
    }
}
