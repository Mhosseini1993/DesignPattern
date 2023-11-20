using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural._02_Facade
{
    public class SubSystem1
    {
        public void Action1()
        {
            Console.WriteLine($"{nameof(Action1)} called from {nameof(SubSystem1)}");
        }
    }

    public class SubSystem2
    {
        public void Action2()
        {
            Console.WriteLine($"{nameof(Action2)} called from {nameof(SubSystem2)}");
        }
    }


    public class SubSystem3
    {
        public void Action3()
        {
            Console.WriteLine($"{nameof(Action3)} called from {nameof(SubSystem3)}");
        }
    }

    public class Facade
    {
        private readonly SubSystem1 sub1;
        private readonly SubSystem2 sub2;
        private readonly SubSystem3 sub3;
        public Facade()
        {
            sub1 = new();
            sub2 = new();
            sub3 = new();
        }
        public void DoActions()
        {
            sub1.Action1();
            sub2.Action2();
            sub3.Action3();
        }
    }
}
