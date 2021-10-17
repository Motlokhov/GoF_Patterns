using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Create.Prototype
{
    internal class Prototype1 : IPrototype
    {
        private int _v1;
        private string _v2;

        public Prototype1(int v1,string v2)
        {
            _v1 = v1;
            _v2 = v2;
        }

        public IPrototype Clone()
        {
            return new Prototype1(_v1, _v2);
        }
    }
}
