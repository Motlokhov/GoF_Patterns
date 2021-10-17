using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Create.Factory_Method
{
    internal class FactoryWithSomeProducts : IMethod
    {
        private int _someParam;

        public FactoryWithSomeProducts(int someParam)
        {
            _someParam = someParam;
        }
        public IProduct GetProduct()
        {
            switch(_someParam)
            {
                case 0: return new FactoryProduct();
                case 1:return new OtherFactoryProduct();
                case 100:return new OtherFactoryProduct();
                default: return new FactoryProduct();
            }
        }
    }
}
