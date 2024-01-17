using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.WithAbstract
{
    public abstract class Handler
    {
        protected Handler? Successor;

        public Handler SetSuccessor(Handler successor)
        {
            this.Successor = successor;
            return Successor;
        }
        public abstract void HandleRequest(int request);
    }
}
