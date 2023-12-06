namespace DesignPattern.Creational._03_FactoryMethod.Example
{
    public class ServiceFactory
    {
        private static ServiceFactory? _serviceFactory = null;
        private ServiceFactory()
        {

        }
        public static ServiceFactory GetInstance()
        {
            if(_serviceFactory == null)
                _serviceFactory = new ServiceFactory();
            return _serviceFactory;
        }
        public ISmsManager FactoryMethod(int n)
        {
            ISmsManager smsManager;
            smsManager=n switch
            {
                0 => new TobaSmsProvider(),
                1 => new GhasedakProvider(),
                2 => new KavehNegarProvider(),
            };
            return smsManager;
        }
    }
    
}
