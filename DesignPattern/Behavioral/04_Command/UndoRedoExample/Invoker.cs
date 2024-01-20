namespace DesignPattern.Behavioral._04_Command.UndoRedoExample
{
    public class Invoker
    {
        //saving list of command that can implement undo and redo actions.
        private List<Command> commands;
        private Reciver reciver;
        private int index = 0;
        public Invoker()
        {
            reciver=new Reciver();
            commands = new List<Command>();
        }
        public string SetText(string strInput)
        {
            Command command = new ConcreteClass(reciver);
            commands.Add(command);
            index+=1;
            string resutl = command.Execute(strInput);
            return resutl;
        }
        public string Redo()
        {
            string res = commands[index].Execute(commands[index].currentText);
            index+=1;
            return res;

        }
        public string Undo()
        {
            index-=1;
            return commands[index].UnExecute(commands[index].currentText);
        }
    }

}
