using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Struct.Facade
{
    internal class Facade2
    {
        Submodule1 module1;
        Submodule3 module3;
        Submodule4 module4;

        public Facade2(Submodule1 m1, Submodule3 m3, Submodule4 m4)
        {
            module1 = m1;
            module3 = m3;
            module4 = m4;
        }
        
        public void Scenario1()
        {
            module4.SomeWork();
            module3.Do();
            module1.DoIt();
        }

        public void Scenario2()
        {
            module1.DoIt();
            module3.Foo();
            module4.SomeWork2();
        }
    }
}
