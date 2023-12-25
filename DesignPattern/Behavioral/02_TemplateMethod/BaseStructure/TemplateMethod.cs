namespace DesignPattern.Behavioral._02_TemplateMethod.BaseStructure
{

    public abstract class TemplateMethod
    {
        public void TemplateOperation()
        {
            //here we have to specify all of steps to do an action.
            PrimitiveOperation1();
            if (PrimitiveOperation2())
                PrimitiveOperation3();
        }
        protected abstract void PrimitiveOperation1();
        protected abstract bool PrimitiveOperation2();
        protected abstract void PrimitiveOperation3();
    }
    public class ConcreteClass : TemplateMethod
    {
        protected override void PrimitiveOperation1()
        {
            Console.WriteLine($"{nameof(PrimitiveOperation1)} run ...");
        }
        protected override bool PrimitiveOperation2()
        {
            int a = 0; int b = 0;

            return a==b;
        }
        protected override void PrimitiveOperation3()
        {
            Console.WriteLine($"{nameof(PrimitiveOperation3)} run...");
        }
    }
    public static class Client
    {
        public static void Run(TemplateMethod templateMethod)
        {
            templateMethod.TemplateOperation();
        }
    }
}
