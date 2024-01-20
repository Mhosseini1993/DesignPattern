using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral._04_Command.UndoRedoExample
{
    public class Reciver
    {
        public string Text { get; set; }
        public string AppendText(string strInput)
        {
            Text+=strInput;
            return Text;
        }
        public string RemoveText(string strInput)
        {
            Text=Text[..^strInput.Length];
            return Text;
        }
    }

}
