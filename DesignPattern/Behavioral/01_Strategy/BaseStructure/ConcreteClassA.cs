namespace DesignPattern.Behavioral._01_Strategy.BaseStructure
{
    public class ConcreteClassA : Strategy
    {
        public override void AbstractAlgorithm()
        {
            Console.WriteLine($"{nameof(AbstractAlgorithm)} of {nameof(ConcreteClassA)} run...");
        }
    }
}
