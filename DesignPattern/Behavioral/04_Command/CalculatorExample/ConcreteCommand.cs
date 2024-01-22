namespace DesignPattern.Behavioral._04_Command.CalculatorExample
{
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Calculator calculator) : base(calculator) { }

        public override int Execute(int num, string operation)
        {
            currentNum=num;
            currentOperation=operation;
            return calculator.Action(num, operation);
        }
        public override int UnExecute(int num, string operation)
        {
            currentNum=num;
            currentOperation=operation;
            return calculator.Action(num, FindOppositeOperation());
        }
    }
}
