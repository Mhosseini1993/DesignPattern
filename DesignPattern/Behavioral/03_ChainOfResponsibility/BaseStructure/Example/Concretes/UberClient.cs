using DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.Example.Model;
using DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.Example.Service;

namespace DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.Example.Concretes
{
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
