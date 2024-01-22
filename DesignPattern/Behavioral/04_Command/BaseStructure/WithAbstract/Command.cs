namespace DesignPattern.Behavioral._04_Command.BaseStructure.WithAbstract
{
    public abstract class Command
    {
        protected Reciver reciver;
        public Command(Reciver reciver)
        {
            this.reciver = reciver;
        }
        public abstract void Execute();
    }
}
