namespace DesignPattern.Behavioral._04_Command.UndoRedoExample
{
    public abstract class Command
    {
        protected Reciver reciver;
        public string currentText { get; set; }
        public Command(Reciver reciver)
        {
            this.reciver=reciver;
        }
        public abstract string Execute(string strInput);

        public abstract string UnExecute(string strInput);
    }

}
