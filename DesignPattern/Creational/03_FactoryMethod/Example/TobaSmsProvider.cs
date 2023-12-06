namespace DesignPattern.Creational._03_FactoryMethod.Example
{
    public class TobaSmsProvider : ISmsManager
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
