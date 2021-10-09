using System;

namespace GoF_Patterns.Struct.Decorator
{
    internal class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component component) : base(component)
        {
        }

        public override void SomeAction()
        {
            base.SomeAction();
            AdditionalAction();
        }

        private void AdditionalAction()
        {
            Console.WriteLine(nameof(ConcreteDecoratorA));
        }
    }
}
