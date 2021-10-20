using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Struct.Proxy
{
    internal class ProtectingProxy : IProxy
    {
        Subject _subject;
        public ProtectingProxy(Subject subject)
        {
            _subject = subject;
        }

        public int Request()
        {
            //validation
            return _subject.Request();
        }
    }
}
