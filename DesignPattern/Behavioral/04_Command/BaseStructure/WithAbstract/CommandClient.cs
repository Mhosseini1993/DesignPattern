namespace DesignPattern.Behavioral._04_Command.BaseStructure.WithAbstract
{
    public static class CommandClient
    {
        public static void Run()
        {
            Reciver reciver=new Reciver();
            Command command = new ConcreteClass(reciver);
            Invoker invoker = new Invoker();
            invoker.SetCommand(command);
            invoker.ExecuteCommand();
        }
    }

}
