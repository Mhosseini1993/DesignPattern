namespace DesignPattern.Behavioral._04_Command.BaseStructure
{
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Reciver reciver) : base(reciver)
        {

        }
        public override void Execute()
        {
            //Logging
            //Undo Redo
            //Run script
            reciver.Action();
        }
    }
}
