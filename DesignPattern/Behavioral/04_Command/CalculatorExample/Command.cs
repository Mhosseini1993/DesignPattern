namespace DesignPattern.Behavioral._04_Command.CalculatorExample
{
    public abstract class Command
    {
        protected Calculator calculator;
        public int currentNum;
        public string currentOperation;
        public Command(Calculator calculator)
        {
            this.calculator = calculator;
        }

        public abstract int Execute(int num, string operation);
        public abstract int UnExecute(int num, string operation);
        public string FindOppositeOperation()
        {
            currentOperation=currentOperation switch
            {
                "+" => "-",
                "-" => "+",
                "*" => "/",
                "/" => "*",
                _ => "+",
            };
            return currentOperation;
        }
    }
}
