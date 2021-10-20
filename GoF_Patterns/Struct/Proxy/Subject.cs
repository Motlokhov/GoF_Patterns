using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Struct.Proxy
{
    internal class Subject : IProxy
    {
        public int Request()
        {
            return 200;
        }
    }
}
