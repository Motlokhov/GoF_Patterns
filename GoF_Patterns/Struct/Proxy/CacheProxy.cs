using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Struct.Proxy
{
    internal class CacheProxy : IProxy
    {
        Subject _subject;
        int cache = default;
        bool isNew = true;

        public CacheProxy(Subject subject)
        {
            _subject = subject;
        }

        public int Request()
        {
            if(isNew)
                cache = _subject.Request();
            return cache;
        }
    }
}
