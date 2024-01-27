using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral._06_Observer.BaseStructure.WithAbstract
{
    public abstract class Publisher
    {
        private List<Observer> observers;
        private string _state;
        public string State
        {
            get => _state;
            set
            {
                _state=value;
                NotifyChanges();
            }
        }
        public Publisher(string initState)
        {
            observers = new List<Observer>();
            _state=initState;
        }
        public void AttachObserver(Observer observer) => observers.Add(observer);
        public void DetachObserver(Observer observer) => observers.Remove(observer);

        //2-logging ==> number of logs decrease
        public void NotifyChanges()
        {
            string str;
            observers.ForEach(ef => ef.Update(out str));
            
        }
    }
    public class ConcretePublisher : Publisher
    {
        public ConcretePublisher(string state) : base(state) { }
    }
    public abstract class Observer
    {
        protected Publisher _publisher;
        protected string Name;
        protected string State { get; set; }
        public Observer(Publisher publisher, string name)
        {
            _publisher = publisher;
            Name=name;
        }
        public void Update(out string str)
        {
            str="";
            //1-Logging a huge amout of logs
            //it can be any property
            State = _publisher.State;
            Console.WriteLine($"State of Observer {Name} changed to the {State}");
        }
    }
    public class ConcreteObserver : Observer
    {
        public ConcreteObserver(Publisher publisher, string name) : base(publisher, name)
        {
        }
    }
    public static class ObserverClient
    {
        public static void Run()
        {
            Publisher publisher = new ConcretePublisher("initState");
            publisher.AttachObserver(new ConcreteObserver(publisher, "Observer1"));
            publisher.AttachObserver(new ConcreteObserver(publisher, "Observer2"));
            publisher.AttachObserver(new ConcreteObserver(publisher, "Observer3"));
            publisher.State="First State";
            Console.WriteLine("***********************");
            Observer observer4 = new ConcreteObserver(publisher, "Observer4");
            publisher.AttachObserver(observer4);
            publisher.State="Second State";
            publisher.DetachObserver(observer4);
            Console.WriteLine("***********************");
            publisher.State="Third State";

        }
    }
}
