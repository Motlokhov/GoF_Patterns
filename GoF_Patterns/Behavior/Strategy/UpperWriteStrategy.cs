using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Behavior.Strategy
{
    internal class UpperWriteStrategy : IStrategy
    {
        public void Do(string input)
        {
            Console.WriteLine($"{nameof(UpperWriteStrategy)} {input.ToUpper()}");
        }
    }
}
