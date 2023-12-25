namespace DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.WithInterface
{
    public class ConcreteClass2 : IHandler
    {
        public IHandler Successor { get; set; }
        public ConcreteClass2(IHandler handler)
        {
            Successor=handler;
        }

        public void HandleRequest(int requestId)
        {
            if (requestId>=50)
            {
                Console.WriteLine($"{requestId} processed by {nameof(ConcreteClass2)}");
            }
            else if (Successor!=null)
            {
                Successor.HandleRequest(requestId);
            }
        }
    }
}
