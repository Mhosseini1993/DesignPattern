namespace DesignPattern.Behavioral._04_Command.UndoRedoExample
{
    public class ConcreteClass : Command
    {
        public ConcreteClass(Reciver reciver) : base(reciver)
        {

        }
        public override string Execute(string strInput)
        {
            currentText=strInput;
            return reciver.AppendText(strInput);
        }
        public override string UnExecute(string strInput)
        {
            currentText=strInput;
            return reciver.RemoveText(strInput);
        }
    }

}
