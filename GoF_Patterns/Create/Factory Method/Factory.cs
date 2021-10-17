using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Create.Factory_Method
{
    internal class Factory : IMethod
    {
        public IProduct GetProduct()
        {
            return new FactoryProduct();
        }
    }
}
