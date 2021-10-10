using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Create.Abstract_Factory
{
    internal class FactoryClient
    {
        public void UseFactory(AbstractFactory factory)
        {
            var a = factory.GetProductA();
            var b = factory.GetProductB();
        }
    }
}
