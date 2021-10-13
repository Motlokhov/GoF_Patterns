﻿using GoF_Patterns.Behavior.Command;
using GoF_Patterns.Behavior.Strategy;
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

            Console.ReadKey();
        }
    }
}
