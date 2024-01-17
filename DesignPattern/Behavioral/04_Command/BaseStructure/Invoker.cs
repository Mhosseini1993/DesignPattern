namespace DesignPattern.Behavioral._04_Command.BaseStructure
{
    public class Invoker
    {
        //Single object of command or list of Commands==Complex Invoker.
        private Command command;
        public void SetCommand(Command command)
        {
            this.command=command;   
        }
        public void ExecuteCommand()
        {
            this.command.Execute();
        }
    }
}
