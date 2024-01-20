namespace DesignPattern.Behavioral._04_Command.BaseStructure.WithInterface
{
    public class ConcreteCommand : ICommand
    {
        public Reciver reciver { get; set; }

        public ConcreteCommand(Reciver reciver)
        {
            this.reciver = reciver;
        }
        public void Execute()
        {
            this.reciver.Action();
        }
    }
}
