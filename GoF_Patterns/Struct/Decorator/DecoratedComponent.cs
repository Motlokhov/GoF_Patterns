using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Struct.Decorator
{
    internal class DecoratedComponent : Component
    {
        public DecoratedComponent()
        {
            Console.WriteLine("Decorator pattern");
        }

        public override void SomeAction()
        {
            Console.WriteLine(nameof(DecoratedComponent));
        }
    }
}
