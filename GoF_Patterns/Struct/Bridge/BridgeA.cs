using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Struct.Bridge
{
    internal class BridgeA : IBridgeAbstraction
    {
        public IBridgeImplementor BridgeImplementor { get; init; }

        public void Operation()
        {
            BridgeImplementor.Operation1Imp();
            SomeOperation();
            BridgeImplementor.Operation2Imp();
        }

        private void SomeOperation()
        {

        }
    }
}
