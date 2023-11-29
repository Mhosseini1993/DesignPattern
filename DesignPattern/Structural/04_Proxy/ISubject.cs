namespace DesignPattern.Structural._04_Proxy
{
    public interface ISubject
    {
        void DoAction();
    }
    public class RealSubject1 : ISubject
    {
        public RealSubject1()
        {
            //Imagine huge amount of configs should do for working with this class
        }
        public void DoAction()
        {
            Console.WriteLine($"{nameof(DoAction)} run from {nameof(RealSubject1)}");
        }
    }
    public class RealSubject2 : ISubject
    {
        public RealSubject2()
        {
            //Imagine huge amount of configs should do for working with this class
        }
        public void DoAction()
        {
            Console.WriteLine($"{nameof(DoAction)} run from {nameof(RealSubject2)}");
        }
    }
    public class RealSubjectProxy : ISubject
    {
        /// <summary>
        /// if we have just one concrete class for ISubject we can
        /// Merge ISubject and RealSubject into a single class and instead of implement of ISubject or inheritance from RealSubject
        /// just use an object of RealSubject in RealSubjectProxy class.
        /// </summary>
        //private RealSubject1? _subject = null;

        private ISubject? _subject = null;//if we have some concrete class for ISubject 

        public void DoAction()
        {
            (_subject??new RealSubject1()).DoAction();
        }
    }
}
