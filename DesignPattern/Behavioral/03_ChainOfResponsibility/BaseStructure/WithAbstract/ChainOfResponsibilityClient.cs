﻿namespace DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.WithAbstract
{
    public static class ChainOfResponsibilityClient
    {
        public static void Run()
        {
            Handler handler2 = new ConcreteHandler2();
            Handler handler1 = new ConcreteHandler1();
            
            handler1.SetSuccessor(handler2);
            handler2.SetSuccessor(null);

            handler1.HandleRequest(40);
            handler1.HandleRequest(100);
        }
    }
}
