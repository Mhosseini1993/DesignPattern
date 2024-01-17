using DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.Example.Model;
using DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.Example.Service;

namespace DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.Example.Concretes
{
    public class CheckTest : IHandler
    {
        public override ResponseContext Execute(RequestContext requestContext)
        {
            Console.WriteLine("Check Test");
            if (Successor!=null)
            {
                return Successor.Execute(requestContext);
            }
            else
            {
                return new ResponseContext() { IsSuccess=false, Message="Error" };
            }
        }
    }
}
