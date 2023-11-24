using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural._05_Composite.BaseStructure
{
    public abstract class Component
    {
        protected string Name;
        public Component(string name)
        {
            Name = name;
        }
        public virtual void Display(int depth = 1)
        {
            Console.WriteLine(new string('-', depth) + Name);
        }
        public virtual int GetChilds()
        {
            return 0;
        }
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
    }
    public class Composite : Component
    {
        private List<Component> _components = new List<Component>();
        public Composite(string name) : base(name) { }
        public Composite(string name, List<Component> components) : base(name)
        {
            _components.AddRange(components);
        }

        public override void Display(int depth = 1)
        {
            base.Display(depth);
            foreach (var item in _components)
            {
                item.Display(depth + 2);
            }
        }
        public override int GetChilds()
        {
            return _components.Count;
        }
        public override void Add(Component component)
        {
            _components.Add(component);
        }
        public override void Remove(Component component)
        {
            _components.Remove(component);
        }
    }
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {

        }

        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
