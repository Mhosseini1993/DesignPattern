namespace DesignPattern.Behavioral._01_Strategy.BaseStructure
{
    public class ConcreteClassB : Strategy
    {
        public override void AbstractAlgorithm()
        {
            Console.WriteLine($"{nameof(AbstractAlgorithm)} of {nameof(ConcreteClassB)} run...");
        }
    }
}
