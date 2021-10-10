using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Create.Abstract_Factory
{
    internal abstract class AbstractFactory
    {
        public abstract AbstractProductA GetProductA();
        public abstract AbstractProductB GetProductB();
        public abstract void FactoryMethod();
    }
}
