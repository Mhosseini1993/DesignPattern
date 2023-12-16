namespace DesignPattern.Behavioral._01_Strategy.BaseStructure
{
    public class ConcreteClassC : Strategy
    {
        public override void AbstractAlgorithm()
        {
            Console.WriteLine($"{nameof(AbstractAlgorithm)} of {nameof(ConcreteClassC)} run...");
        }
    }
}
