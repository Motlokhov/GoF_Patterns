using System;

namespace GoF_Patterns.Behavior.Observer
{
    internal class IntSumObserver : IMyObserver
    {
        ConcreteModel _model;
        int _sum;

        public void SetNotifier(ConcreteModel notifier)
        {
            _model = notifier;
        }

        public void Sum(int x)
        {
            _sum = 2 * x;
        }

        public void Update()
        {
            Sum(_model.X);
            Console.WriteLine($"Sum is {_sum}");
        }
    }
}
