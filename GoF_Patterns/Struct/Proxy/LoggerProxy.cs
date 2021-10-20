using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Struct.Proxy
{
    internal class LoggerProxy : IProxy
    {
        Subject _subject;
        public LoggerProxy(Subject subject)
        {
            _subject = subject;
        }

        public int Request()
        {
            //logging before
            return _subject.Request();
            //logging after
        }


    }
}
