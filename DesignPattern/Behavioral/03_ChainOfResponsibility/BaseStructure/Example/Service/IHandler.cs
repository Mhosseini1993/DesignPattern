using DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.Example.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.Example.Service
{
    public abstract class IHandler
    {
        protected IHandler? Successor { get; set; }
        public IHandler SetSuccessor(IHandler handler)
        {
            Successor = handler;
            return Successor;
        }
       public abstract ResponseContext Execute(RequestContext requestContext);
    }
}
