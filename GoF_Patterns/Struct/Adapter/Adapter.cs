using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Struct.Adapter
{
    internal class Adapter:ITarget
    {
        private Adaptee _adaptee;

        public void SomeWork()
        {
            //wrap a same work from other class
            _adaptee.Foo1();
            _adaptee.Foo3();
            _adaptee.Foo2();
        }
    }
}
