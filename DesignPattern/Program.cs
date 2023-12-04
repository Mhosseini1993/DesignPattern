// See https://aka.ms/new-console-template for more information


#region Decorator
//using DesignPattern.Structural._01_Decorator.DecoratorVsInheritance.WithDecorator;
//using DesignPattern.Structural._01_Decorator.WithAbstraction;

//Component decorator_obj = new ConcreteComponent();
//decorator_obj.Operation();
//Decorator decorator_NewObj = new ConcreteDecorator(decorator_obj);
//decorator_NewObj.Operation();

//IWindow window = new Window();
//window.Draw();

//WindowDecorator borderWindow = new BorderedWindow(new ScrollableWindow(window));
//borderWindow.Draw();
#endregion

#region Facade
//using DesignPattern.Structural._02_Facade;

//Facade facade = new Facade();
//facade.DoActions();
#endregion

#region Bridge
//using DesignPattern.Structural._03_Bridge.BaseStructure;
//using DesignPattern.Structural._03_Bridge.Example;

//Abstraction abstraction = new RefinedAbstraction();
//abstraction.Function();

//MailServiceAbstraction ob = new RefiendMailService();
//ob.Send(new RequestMessageDto()
//{
//    Message = "sdsd",
//    To = "sdfsd",
//    Subject = "sdfsd"
//});
#endregion

#region Proxy
//using DesignPattern.Structural._04_Proxy;

//RealSubjectProxy ob = new RealSubjectProxy();
//if (1 == 1)
//    ob.DoAction();
#endregion

#region Composite
//using DesignPattern.Structural._05_Composite.BaseStructure;

//Component composite = new Composite("Root Item", new List<Component>()
//{
//    new Leaf("Leaf 1"),
//    new Composite("Composite 1",new List<Component>()
//    {
//        new Leaf("Leaf 1-1"),
//        new Leaf("Leaf 1-2"),
//        new Composite("Composite 1-1",new List<Component>()
//        {
//            new Leaf("Leaf 1-1-1"),
//            new Composite("empty Composite",new List<Component>()
//            {
//            })
//        }),
//        new Leaf("Leaf 2"),
//        new Leaf("Leaf 3"),
//        new Leaf("Leaf 4"),
//    })
//});
//composite.Display();


using DesignPattern.Creational._01_Prototype.DeepCopy;
using DesignPattern.Creational._01_Prototype.ShallowCopy;
using DesignPattern.Creational._02_Singletone.EagerInit;
using DesignPattern.Structural._05_Composite.Example;
IComponent hardDisk = new Leaf("Hard Disk", 100000);
IComponent ram = new Leaf("RAM", 100000);
IComponent cpu = new Leaf("CPU", 200000);

IComponent mouse = new Leaf("mouse", 50000);
IComponent keyboard = new Leaf("keyboard", 50000);
IComponent monitor = new Leaf("monitor", 400000);

IComponent motherBoard = new Composite("motherBoard", 100000);
IComponent Case = new Composite("Case", 70000);
IComponent periperal = new Composite("periperal", 0);
IComponent computer = new Composite("computer", 0);

motherBoard.Add(ram);
motherBoard.Add(cpu);

Case.Add(hardDisk);
Case.Add(motherBoard);

periperal.Add(mouse);
periperal.Add(keyboard);
periperal.Add(monitor);

computer.Add(periperal);
computer.Add(Case);

computer.GetPrice();

#endregion

Console.ReadKey();
