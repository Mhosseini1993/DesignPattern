namespace DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.WithInterface
{
    public static class ChainOfResponsibility
    {
        public static void Run()
        {
            IHandler concrete2 = new ConcreteClass2();
            IHandler concrete1 = new ConcreteClass1();
            concrete1.SetSuccessor(concrete2);

            concrete1.HandleRequest(10);
            concrete1.HandleRequest(500);
        }
    }
}
