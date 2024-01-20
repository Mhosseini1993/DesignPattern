namespace DesignPattern.Behavioral._04_Command.BaseStructure.WithAbstract
{
    public class ConcreteClass : Command
    {
        public ConcreteClass(Reciver reciver):base(reciver) 
        {
            
        }
        public override void Execute()
        {
            //Logging user activities.
            //Undo & Redo.
            reciver.Action();
        }
    }

}
