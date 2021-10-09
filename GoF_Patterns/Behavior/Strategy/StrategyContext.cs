using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Behavior.Strategy
{
    internal class StrategyContext
    {
        public StrategyContext()
        {
            Console.WriteLine("Strategy pattern");
        }

        public void UseStrategy(IStrategy strategy, string input)
        {
            strategy.Do(input);
        }
    }
}
