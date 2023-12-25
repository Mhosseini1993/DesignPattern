using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.WithInterface
{
    public interface IHandler
    {
        IHandler Successor { get; set; }
        void HandleRequest(int requestId);
    }
}
