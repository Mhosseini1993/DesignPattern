using DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.Example.Model;
using DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.Example.Service;

namespace DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.Example.Concretes
{
    public class SendToDriver : IHandler
    {
        public override ResponseContext Execute(RequestContext requestContext)
        {
            if (Successor !=null)
            {
                Console.WriteLine($"Order Send to Drivers at {DateTime.Now} and send to {Successor.GetType().Name}");
                return Successor.Execute(requestContext);
            }
            else
            {
                Console.WriteLine($"Order Send to Drivers at {DateTime.Now} and finished");
                return new ResponseContext()
                {
                    IsSuccess = false,
                    Message="order created and send to drivers and finished"
                };
            }
        }
    }
}
