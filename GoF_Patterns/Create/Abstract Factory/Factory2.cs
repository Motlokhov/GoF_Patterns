using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Create.Abstract_Factory
{
    internal class Factory2 : AbstractFactory
    {
        public override AbstractProductA GetProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB GetProductB()
        {
            return new ProductB2();
        }
    }
}
