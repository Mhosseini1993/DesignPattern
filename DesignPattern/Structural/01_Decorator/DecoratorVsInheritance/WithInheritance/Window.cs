using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural._01_Decorator.DecoratorVsInheritance.WithInheritance
{
    public class Window
    {
        public void Draw()
        {
            Console.WriteLine("Window created!!");
        }
    }

    public class BorderedWindow : Window
    {
        public void MakeBorder()
        {
            base.Draw();
            Console.WriteLine("Border Added to window");
        }
    }
    public class ScrollableWindow : Window
    {
        public void MakeScrollable()
        {
            base.Draw();
            Console.WriteLine("Scroll Added to windows");
        }
    }

    public class BorderedScrollableWindow:Window
    {
       public void MakeBorderAndScrollable()
        {
            base.Draw();
            Console.WriteLine("Border Added");
            Console.WriteLine("Scroll Added");
        }
    }
}
