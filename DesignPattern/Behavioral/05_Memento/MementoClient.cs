namespace DesignPattern.Behavioral._05_Memento
{
    public static class MementoClient
    {
        public static void Run()
        {
            Originator originator = new Originator();
            originator.State="Red";
            CareTaker careTaker = new CareTaker();
            careTaker.Memento = originator.CreateMemento();
            originator.State="Yellow";
            originator.State="Blue";
            originator.State="Brown";

            originator.SetMemento(careTaker.Memento);
        }
    }
}
