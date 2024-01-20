namespace DesignPattern.Behavioral._04_Command.BaseStructure.WithInterface
{
    public interface ICommand
    {
        Reciver reciver { get; set; }
        void Execute();
    }
}
