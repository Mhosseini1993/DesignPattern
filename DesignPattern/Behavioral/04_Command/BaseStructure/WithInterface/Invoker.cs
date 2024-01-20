namespace DesignPattern.Behavioral._04_Command.BaseStructure.WithInterface
{
    public class Invoker
    {
        private ICommand command;
        public void SetCommand(ICommand command)
        {
            this.command = command;
        }
        public void ExecuteCommand() 
        {
            this.command.Execute();
        }
    }
}
