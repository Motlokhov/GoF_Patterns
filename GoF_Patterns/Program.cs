using GoF_Patterns.Behavior.Command;
using GoF_Patterns.Behavior.Iterator;
using GoF_Patterns.Behavior.Mediator;
using GoF_Patterns.Behavior.Memento;
using GoF_Patterns.Behavior.Observer;
using GoF_Patterns.Behavior.Strategy;
using GoF_Patterns.Behavior.Visitor;
using GoF_Patterns.Create.Builder;
using GoF_Patterns.Create.Singleton;
using GoF_Patterns.Struct.Decorator;
using System;
using static GoF_Patterns.Behavior.Memento.MementoBox.Memento;

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

            Singleton.Instance.Value = "I'm alive";
            Console.WriteLine(Singleton.Instance.Value);
            Console.WriteLine(string.Empty);

            ConcreteMediator mediator = new ConcreteMediator();
            mediator.Button.Changed();
            mediator.Button.Changed();
            Console.WriteLine(string.Empty);

            Author author = new Author();
            MementoBox careTaker = author.SaveState();
            author.ChangeState(1, 1, 1);
            author.RollbackState(careTaker);
            Console.WriteLine(string.Empty);

            ConcreteModel model = new ConcreteModel();
            IntSquareObserver intSquare = new IntSquareObserver();
            IntSumObserver intSum = new IntSumObserver();
            model.AddObserver(intSquare);
            model.AddObserver(intSum);
            intSquare.SetNotifier(model);
            intSum.SetNotifier(model);
            model.X = 2;
            model.X = 5;

            Console.ReadKey();
        }
    }
}
