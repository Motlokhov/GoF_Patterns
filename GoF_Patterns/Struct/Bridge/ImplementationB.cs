using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Struct.Bridge
{
    internal class ImplementationB : IBridgeImplementor
    {
        public void Operation1Imp()
        {
            throw new NotImplementedException();
        }

        public void Operation2Imp()
        {
            throw new NotImplementedException();
        }
    }
}
