using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Behavior.Visitor
{
    internal class Visitor
    {
        public void Increment (ObjectForVisit obj)
        {
            obj.i++;
        }
    }
}
