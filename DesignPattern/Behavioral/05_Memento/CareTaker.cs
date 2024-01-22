namespace DesignPattern.Behavioral._05_Memento
{
    public class CareTaker
    {
        private Memento? _memento;
        public Memento? Memento
        {
            get => _memento;

            set
            {
                Console.WriteLine("Caretaker Set Memento...");
                _memento = value;
            }
        }
    }
}
