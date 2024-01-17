using DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.Example.Model;
using DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.Example.Service;

namespace DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.Example.Concretes
{
    public class CheckUserActiveStatus : IHandler
    {
        public override ResponseContext Execute(RequestContext requestContext)
        {
            if (requestContext.UserId!=1)
            {
                Console.WriteLine("User is not active");
                return new ResponseContext()
                {
                    IsSuccess=false,
                    Message="User is not active"
                };
            }
            else
            {
                if (Successor!=null)
                {
                    Console.WriteLine($"User is Active and send to {Successor.GetType().Name}");
                    return Successor.Execute(requestContext);
                }
                else
                {
                    return new ResponseContext()
                    {
                        IsSuccess = false,
                        Message="Error"
                    };
                }
            }
        }
    }
}
