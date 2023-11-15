namespace DesignPattern.Structrual._03_Bridge.Example
{
    public abstract class MailServiceAbstraction
    {
        private readonly IMailServiceBridge _bridge;
        public MailServiceAbstraction()
        {
            _bridge=MailServiceProvider.GetProvider("gmail");
        }
        public virtual void Send(RequestMessageDto dto)
        {
            _bridge.SendMessage(dto.Subject, dto.Message, dto.To);
        }
    }

    public static class MailServiceProvider
    {
        public static IMailServiceBridge GetProvider(string provider)
        {
            IMailServiceBridge bridge = null;

            bridge=provider.Trim().ToUpper() switch
            {
                "GMAIL" => new GamilService(),
                "YAHOO" => new YahooService(),
                "SMS" => new SmsService(),
                _=>new SmsService()
            };

            return new GamilService();
        }
    }

    public class RefiendMailService : MailServiceAbstraction
    {

    }

    public class RequestMessageDto
    {
        public string Message { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }

    }

}
