using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Behavior.Visitor
{
    internal class ObjectForVisit
    {
        public int i = 0;

        public ObjectForVisit()
        {
            Console.WriteLine("Visitor pattern");
        }

        private void Print()
        {
            Console.WriteLine($"Print {i}");
        }

        public void Accept(Visitor v)
        {
            Print();
            v.Increment(this);
            Print();
        }

    }
}
