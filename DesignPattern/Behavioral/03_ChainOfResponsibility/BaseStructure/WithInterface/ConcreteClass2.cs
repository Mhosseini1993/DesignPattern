namespace DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.WithInterface
{
    public class ConcreteClass2 : IHandler
    {
        public IHandler Successor { get; set; }
        public IHandler SetSuccessor(IHandler successor)
        {
            Successor = successor;
            return Successor;
        }
        public void HandleRequest(int requestId)
        {
            if (requestId>=50)
            {
                Console.WriteLine($"{requestId} processed by {nameof(ConcreteClass2)}");
            }
            else 
            {
                Successor?.HandleRequest(requestId);
            }
        }
    }
}
