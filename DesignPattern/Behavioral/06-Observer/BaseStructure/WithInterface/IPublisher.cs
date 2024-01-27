using DesignPattern.Behavioral._06_Observer.BaseStructure.WithAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPattern.Behavioral._06_Observer.BaseStructure.WithInterface
{
    public interface IPublisher
    {
        List<IObserver> observers { set; get; }
        string State { get; set; }
        void AttachObserver(IObserver observer);
        void DetachObserver(IObserver observer);
        void NotifyChanges();
    }
    public class ConcretePublisher : IPublisher
    {
        public List<IObserver> observers { get; set; }
        private string _state;
        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                _state=value;
                NotifyChanges();
            }
        }

        public ConcretePublisher(string initState)
        {
            observers = new List<IObserver>();
            State=initState;
        }
        public void AttachObserver(IObserver observer) => observers.Add(observer);
        public void DetachObserver(IObserver observer) => observers.Remove(observer);
        public void NotifyChanges() => observers.ForEach(ef => ef.Update());

    }
    public interface IObserver
    {
        IPublisher publisher { get; set; }
        public string Name { get; set; }
        void Update();
    }
    public class ConcreteObserver : IObserver
    {
        public IPublisher publisher { get; set; }
        public string State { get; set; }
        public string Name { get; set; }
        public ConcreteObserver(IPublisher publisher, string name)
        {
            this.publisher=publisher;
            Name=name;
        }
        public void Update()
        {
            State=publisher.State;
            Console.WriteLine($"State of Observer {Name} changed to the {State}");
        }
    }
    public static class ObserverClient
    {
        public static void Run()
        {
            IPublisher publisher = new ConcretePublisher("InitState");
            publisher.AttachObserver(new ConcreteObserver(publisher, "Observer1"));
            publisher.AttachObserver(new ConcreteObserver(publisher, "Observer2"));
            publisher.AttachObserver(new ConcreteObserver(publisher, "Observer3"));
            publisher.State="First State";
            Console.WriteLine("***********************");
            IObserver observer4 = new ConcreteObserver(publisher, "Observer4");
            publisher.AttachObserver(observer4);
            publisher.State="Second State";
            publisher.DetachObserver(observer4);
            Console.WriteLine("***********************");
            publisher.State="Third State";
        }
    }
}
