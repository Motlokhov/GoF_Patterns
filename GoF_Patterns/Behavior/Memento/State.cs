using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Behavior.Memento
{
    internal struct State
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }

        public void ChangeState(int x,int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"Now state is X:{X},Y:{Y},Z:{Z}";
        }
    }
}
