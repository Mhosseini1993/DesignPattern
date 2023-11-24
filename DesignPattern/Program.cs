// See https://aka.ms/new-console-template for more information

using DesignPattern.Structural._01_Decorator.DecoratorVsInheritance;
using DesignPattern.Structural._01_Decorator.DecoratorVsInheritance.WithDecorator;
using DesignPattern.Structural._01_Decorator.WithAbstraction;
using DesignPattern.Structural._02_Facade;
using DesignPattern.Structural._03_Bridge.BaseStructure;
using DesignPattern.Structural._03_Bridge.Example;
using DesignPattern.Structural._04_Proxy;

#region Decorator
Component decorator_obj = new ConcreteComponent();
decorator_obj.Operation();
Decorator decorator_NewObj = new ConcreteDecorator(decorator_obj);
decorator_NewObj.Operation();

IWindow window = new Window();
window.Draw();

WindowDecorator borderWindow = new BorderedWindow(new ScrollableWindow(window));
borderWindow.Draw();
#endregion



#region Facade
Facade facade = new Facade();
facade.DoActions();
#endregion

#region Bridge
//Abstraction abstraction = new RefinedAbstraction();
//abstraction.Function();

//MailServiceAbstraction ob=new RefiendMailService();
//ob.Send(new RequestMessageDto()
//{
//    Message="sdsd",
//    To="sdfsd",
//    Subject="sdfsd"
//});
#endregion

#region Proxy
RealSubjectProxy ob = new RealSubjectProxy();
if (1==1)
    ob.DoAction();
#endregion

Console.ReadKey();
