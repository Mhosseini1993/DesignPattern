namespace DesignPattern.Behavioral._01_Strategy.BaseStructure
{
    public static class StrategyClient
    {
        public static void Run()
        {
            Context context;
            context= new Context(new ConcreteClassA());
            context.ApplyAlgorithm();

            context= new Context(new ConcreteClassB());
            context.ApplyAlgorithm();

            context= new Context(new ConcreteClassC());
            context.ApplyAlgorithm();
        }
    }
}
