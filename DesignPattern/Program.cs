// See https://aka.ms/new-console-template for more information

using DesignPattern.Structrual._01_Decorator.DecoratorVsInheritance;
using DesignPattern.Structrual._01_Decorator.DecoratorVsInheritance.WithDecorator;
using DesignPattern.Structrual._01_Decorator.WithAbstraction;
using DesignPattern.Structrual._02_Facade;
using DesignPattern.Structrual._03_Bridge.BaseStructure;
using DesignPattern.Structrual._03_Bridge.Example;

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
Facade facade=new Facade();
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

Console.ReadLine();
