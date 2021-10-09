using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Behavior.Strategy
{
    internal class LowerWriteStrategy : IStrategy
    {
        public void Do(string input)
        {
            Console.WriteLine($"{nameof(LowerWriteStrategy)} {input.ToLower()}");
        }
    }
}
