namespace DesignPattern.Behavioral._04_Command.BaseStructure.WithAbstract
{
    public class Invoker
    {
        private Command command;
        
        public void SetCommand(Command command)
        {
            this.command = command;
        }
        public void ExecuteCommand()
        {
            command.Execute();
        }
    }
}
