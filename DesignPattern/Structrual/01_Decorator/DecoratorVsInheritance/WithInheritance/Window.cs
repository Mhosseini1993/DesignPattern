using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structrual._01_Decorator.DecoratorVsInheritance.WithInheritance
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

    public class BorderedScrollableWindow:BorderedWindow
    {
       public void MakeBorderAndScrollable()
        {
            base.MakeBorder();
            Console.WriteLine("Scroll Added");
        }
    }
}
