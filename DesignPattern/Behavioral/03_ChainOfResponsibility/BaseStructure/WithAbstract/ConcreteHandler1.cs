namespace DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.WithAbstract
{
    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request<50)
            {
                Console.WriteLine($"{request} processed by {nameof(ConcreteHandler1)}");
            }
            else
            {
                Successor?.HandleRequest(request);
            } 
        }
    }
}
