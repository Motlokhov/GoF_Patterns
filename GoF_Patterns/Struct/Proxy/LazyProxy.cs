using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Struct.Proxy
{
    internal class LazyProxy : IProxy
    {
        Lazy<Subject> _subject;
        public LazyProxy(Subject subject)
        {
            _subject = new Lazy<Subject>(subject);
        }
        public int Request()
        {
            return _subject.Value.Request();
        }
    }
}
