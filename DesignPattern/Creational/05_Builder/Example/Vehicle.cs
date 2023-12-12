using DesignPattern.Creational._05_Builder.BaseStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational._05_Builder.Example
{
    public class Vehicle
    {
        public string Type { get; private set; }
        private Dictionary<string, string> parts = new Dictionary<string, string>();
        public Vehicle(string type)
        {
            Type = type;
        }        
        public void AddPart(string partName, string partValue)
        {
            if (!parts.ContainsKey(partName))
            {
                parts.Add(partName, partValue);
            }
        }
    }

    public abstract class VehicleBuilder
    {
        protected Vehicle vehicle;

        public abstract void SetFrame();
        public abstract void SetEngine();
        public abstract void SetDoor();
        public abstract void SetWheel();
        public abstract void SetFuel();
        public virtual Vehicle GetVehicle() => vehicle;

    }

    public class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder()
        {
            vehicle=new Vehicle("MotorCycle");
        }

        public override void SetDoor()
        {
            vehicle.AddPart("Door", "None");
        }
        public override void SetEngine()
        {
            vehicle.AddPart("Engine", "Mechanical");
        }
        public override void SetFrame()
        {
            throw new NotImplementedException();
        }
        public override void SetFuel()
        {
            vehicle.AddPart("Fuel", "None");
        }
        public override void SetWheel()
        {
            vehicle.AddPart("Wheel", "Two");
        }
    }
    public class SportCarBuilder : VehicleBuilder
    {
        public SportCarBuilder()
        {
            vehicle=new Vehicle("Sport Car");
        }

        public override void SetDoor()
        {
            vehicle.AddPart("Door", "2 Doors");
        }
        public override void SetEngine()
        {
            vehicle.AddPart("Engine", "Mechanical Engine");

        }
        public override void SetFrame()
        {
            vehicle.AddPart("Frame", "Iron");
        }
        public override void SetFuel()
        {
            vehicle.AddPart("Fuel", "Gasoline");
        }
        public override void SetWheel()
        {
            vehicle.AddPart("Wheel", "4 Wheels");
        }
    }

    public class MotorCycleDirector
    {
        private VehicleBuilder _builder;
        public VehicleBuilder Builder
        {
            set
            {

                _builder = value;
            }
        }

        public void Construct()
        {
            _builder.SetEngine();
            _builder.SetDoor();
            _builder.SetWheel();
            _builder.SetFuel();
        }
    }
    public class CarDirector
    {
        private VehicleBuilder _builder;
        public VehicleBuilder Builder
        {
            set
            {
                _builder = value;
            }
        }

        public void Construct()
        {
            _builder.SetFrame();
            _builder.SetEngine();
            _builder.SetDoor();
            _builder.SetWheel();
            _builder.SetFuel();
        }
    }
}
