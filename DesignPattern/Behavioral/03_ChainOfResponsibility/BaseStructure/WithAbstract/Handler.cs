using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.WithAbstract
{
    public abstract class Handler
    {
        protected Handler Successor;

        public void SetSuccessor(Handler successor)
        {
            this.Successor = successor;
        }
        public abstract void HandleRequest(int request);
    }
}
