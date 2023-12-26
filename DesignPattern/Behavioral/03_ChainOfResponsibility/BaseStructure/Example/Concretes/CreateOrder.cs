using DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.Example.Model;
using DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.Example.Service;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.Example.Concretes
{
    public class CreateOrder : IHandler
    {
        public override ResponseContext Execute(RequestContext requestContext)
        {
            bool orderCreated = true;
            if (orderCreated)
            {
                Console.WriteLine($"Order Created at {DateTime.Now}");
                if (Successor!=null)
                    return Successor.Execute(requestContext);
                else
                {
                    return new ResponseContext()
                    {
                        IsSuccess = false,
                        Message=$"Order Created successfully at {DateTime.Now}"
                    };
                }
            }
            else
            {
                return new ResponseContext()
                {
                    IsSuccess = false,
                    Message="Order Failed to created"
                };
            }

        }
    }
    public class SendToDriver : IHandler
    {
        public override ResponseContext Execute(RequestContext requestContext)
        {
            if (Successor !=null)
            {
                Console.WriteLine("Order Send to Drivers");
                return Successor.Execute(requestContext);
            }
            else
            {
                return new ResponseContext()
                {
                    IsSuccess = false,
                    Message="order created and send to drivers"
                };
            }
        }
    }
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
            else if (Successor!=null)
            {
                Console.WriteLine("User is Active");
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
  
    public static class UberClient
    {
        public static void Run()
        {
            IHandler checkUserActiveStatus = new CheckUserActiveStatus();
            IHandler createOrder = new CreateOrder();
            IHandler sendToDriver = new SendToDriver();
            IHandler checkTest = new CheckTest();

            checkUserActiveStatus
                  .SetSuccessor(createOrder)
                  .SetSuccessor(sendToDriver)
                  .SetSuccessor(checkTest);


            checkUserActiveStatus.Execute(new RequestContext()
            {
                UserId= 1,
                Origin=new Point() { Lat=1, Long=1 },
                Destination=new Point() { Lat=1, Long=1 }
            });

        }
    }
}
