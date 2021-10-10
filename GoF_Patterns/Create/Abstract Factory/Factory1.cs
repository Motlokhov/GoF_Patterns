using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Create.Abstract_Factory
{
    internal class Factory1 : AbstractFactory
    {
        public override void FactoryMethod()
        {
            Console.WriteLine($"{nameof(Factory1)}.Method");
        }

        public override AbstractProductA GetProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB GetProductB()
        {
            return new ProductB1();
        }
    }
}
