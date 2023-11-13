// See https://aka.ms/new-console-template for more information

using DesignPattern.Structrual._01_Decorator.DecoratorVsInheritance;
using DesignPattern.Structrual._01_Decorator.DecoratorVsInheritance.WithDecorator;
using DesignPattern.Structrual._01_Decorator.WithAbstraction;

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



Console.ReadLine();
