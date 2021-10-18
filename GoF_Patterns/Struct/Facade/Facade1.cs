using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Struct.Facade
{
    internal class Facade1
    {
        Submodule1 module1;
        Submodule2 module2;
        Submodule4 module4;

        public Facade1(Submodule1 m1, Submodule2 m2, Submodule4 m4)
        {
            module1 = m1;
            module2 = m2;
            module4 = m4;
        }

        public void Scenario1()
        {
            module1.DoIt();
            module4.SomeWork();
        }

        public void Scenario2()
        {
            module2.Send();
            module1.DoIt();
        }

        public void Scenario3()
        {
            module2.Send();
            module1.DoIt();
            module4.SomeWork();
            module2.Recieve();
        }
    }
}
