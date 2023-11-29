namespace DesignPattern.Structural._03_Bridge.Example
{
    public abstract class MailServiceAbstraction
    {
        private readonly IMailServiceBridge _bridge;
        public MailServiceAbstraction()
        {
            _bridge = MailServiceProvider.GetProvider("gmail");
        }
        public virtual void Send(RequestMessageDto dto)
        {
            _bridge.SendMessage(dto.Subject, dto.Message, dto.To);
        }
    }
    public class RefiendMailService : MailServiceAbstraction
    {

    }

    public static class MailServiceProvider
    {
        public static IMailServiceBridge GetProvider(string provider)
        {
            IMailServiceBridge bridge = null;

            bridge = provider.Trim().ToUpper() switch
            {
                "GMAIL" => new GmailService(),
                "YAHOO" => new YahooService(),
                "SMS" => new SmsService(),
                _ => new SmsService()
            };

            return new GmailService();
        }
    }

    public class RequestMessageDto
    {
        public string Message { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }

    }

}
