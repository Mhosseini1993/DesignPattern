namespace DesignPattern.Behavioral._05_Memento
{
    public class Memento
    {
        private string _state;
        public Memento(string state)
        {
            this._state = state;
        }
        public string State { get { return _state; } private set { } }
    }
}
