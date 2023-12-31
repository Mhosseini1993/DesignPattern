﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural._01_Decorator.DecoratorVsInheritance.WithDecorator
{
    public interface IWindow
    {
       void Draw();
    }

    public class Window : IWindow
    {
        public  void Draw()
        {
            Console.WriteLine("Window Created!!!");
        }
    }

    public abstract class WindowDecorator : IWindow
    {
        private readonly IWindow _win;

        public WindowDecorator(IWindow window)
        {
            this._win=window;
        }
        public virtual void Draw()
        {
            _win.Draw();
        }
    }

    public class BorderedWindow : WindowDecorator
    {
        public BorderedWindow(IWindow window):base(window)
        {
            
        }
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Border Added");
        }
    }

    public class ScrollableWindow : WindowDecorator
    {
        public ScrollableWindow(IWindow window):base(window)
        {
            
        }
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Scroll Added");
        }
    }

}
