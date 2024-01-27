namespace DesignPattern.Behavioral._05_Memento
{
    public class Memento
    {
        public string State { get; private set; }
        public Memento(string state)
        {
            this.State = state;
        }
    }
}
