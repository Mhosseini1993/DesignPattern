namespace DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.WithInterface
{
    public class ConcreteClass1 : IHandler
    {
        public IHandler Successor { get; set; }

        public ConcreteClass1(IHandler handler)
        {
            Successor = handler;
        }

        public void HandleRequest(int requestId)
        {
            if (requestId<50)
            {
                Console.WriteLine($"{requestId} processed by {nameof(ConcreteClass1)}");
            }
            else if (Successor!=null)
            {
                Successor.HandleRequest(requestId);
            }
        }
    }
}
