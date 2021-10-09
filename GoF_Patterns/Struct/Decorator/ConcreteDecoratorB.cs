using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Struct.Decorator
{
    internal class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component component) : base(component)
        {
        }

        public override void SomeAction()
        {
            base.SomeAction();
            AnoterAction();
        }

        private void AnoterAction()
        {
            Console.WriteLine(nameof(ConcreteDecoratorB));
        }
    }
}
