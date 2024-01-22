namespace DesignPattern.Behavioral._04_Command.CalculatorExample
{
    public class Invoker
    {
        private List<Command> commands;
        private Calculator calculator;
        int index = 0;
        public Invoker()
        {
            commands=new List<Command>();
            calculator=new Calculator();
        }
        public int ExecuteCommand(int num, string operation)
        {
            Command command=new ConcreteCommand(calculator);
            commands.Add(command);
            index++;
            int result=command.Execute(num, operation); 
            return result;  
        }
        public int Redo()
        {
            int res = commands[index].Execute(commands[index].currentNum, commands[index].currentOperation);
            index+=1;
            return res;
        }
        public int Undo()
        {
            index-=1;
            return commands[index].UnExecute(commands[index].currentNum, commands[index].currentOperation);
        }
    }
}
