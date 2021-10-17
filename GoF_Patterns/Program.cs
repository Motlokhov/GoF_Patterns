using GoF_Patterns.Behavior.Command;
using GoF_Patterns.Behavior.Iterator;
using GoF_Patterns.Behavior.Strategy;
using GoF_Patterns.Behavior.Visitor;
using GoF_Patterns.Create.Builder;
using GoF_Patterns.Struct.Decorator;
using System;

namespace GoF_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new ConcreteDecoratorB(new ConcreteDecoratorA(new DecoratedComponent()))
                .SomeAction();
            Console.WriteLine(string.Empty);

            var context = new StrategyContext();
            context.UseStrategy(new UpperWriteStrategy(), "Some strinG");
            context.UseStrategy(new LowerWriteStrategy(), "Some strinG");
            Console.WriteLine(string.Empty);

            var commandClient = new CommandClient();
            commandClient.FirstInvoke();
            commandClient.SecondInvoke();
            commandClient.ThirdInvoke();
            Console.WriteLine(string.Empty);

            foreach(var item in new ReverceIterator(1, 2, 3))
                Console.Write(item);
            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);

            new ObjectForVisit().Accept(new Visitor());
            Console.WriteLine(string.Empty);

            Director director = new Director();

            CarBuilder carBuilder = new();
            director.MakeSportCar(carBuilder);
            Car sportCar = carBuilder.GetResult();

            CarManualBuilder carManualBuilder = new();
            director.MakeSportCar(carManualBuilder);
            CarManual carManual = carManualBuilder.GetResult();
            Console.WriteLine("Builder pattern end");
            Console.WriteLine(string.Empty);

            Console.ReadKey();
        }
    }
}
