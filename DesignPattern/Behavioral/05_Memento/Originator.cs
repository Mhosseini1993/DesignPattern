using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral._05_Memento
{
    public class Originator
    {
        private string _state;
        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                Console.WriteLine($"State = {value}");
                _state = value;
            }
        }
        public Memento CreateMemento()
        {
            Console.WriteLine("Saving Current State ...");
            return new Memento(this._state);
        }
        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restoring last State ...");
            this._state=memento.State;
        }
    }
}
