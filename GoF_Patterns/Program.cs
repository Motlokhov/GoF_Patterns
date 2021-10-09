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
            Console.ReadKey();
        }
    }
}
