namespace DesignPattern.Behavioral._01_Strategy.BaseStructure
{
    public class Context
    {
        private Strategy _strategy;
        public Context(Strategy strategy)
        {
            this._strategy=strategy;
        }
        public void ApplyAlgorithm()
        {
            _strategy.AbstractAlgorithm();
        }
    }
}
