namespace DesignPattern.Behavioral._04_Command.BaseStructure.WithInterface
{
    public static class CommandClient
    {
        public static void Run()
        {
            Invoker invoker = new Invoker();
            Reciver reciver = new Reciver();
            ICommand command = new ConcreteCommand(reciver);
            invoker.SetCommand(command);
            invoker.ExecuteCommand();
        }
    }
}
