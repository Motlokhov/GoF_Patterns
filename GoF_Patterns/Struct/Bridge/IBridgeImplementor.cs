using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Struct.Bridge
{
    internal interface IBridgeImplementor
    {
        void Operation1Imp();
        void Operation2Imp();
    }
}
