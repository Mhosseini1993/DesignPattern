namespace DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.WithAbstract
{
    public static class ChainOfResponsibilityClient
    {
        public static void Run()
        {
            Handler handler1 = new ConcreteHandler1();
            Handler handler2 = new ConcreteHandler2();

            handler1.SetSuccessor(handler2);
            

            handler1.HandleRequest(40);
            handler1.HandleRequest(100);
        }
    }
}
