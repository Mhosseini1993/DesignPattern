namespace DesignPattern.Creational._03_FactoryMethod.Example
{
    public class KavehNegarProvider : ISmsManager
    {
        public List<MessageDto> GetMessages()
        {
            throw new NotImplementedException();
        }

        public void SendMessage(MessageDto msg)
        {
            throw new NotImplementedException();
        }
    }
}
