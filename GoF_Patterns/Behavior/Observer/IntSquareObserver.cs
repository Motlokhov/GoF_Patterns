using System;

namespace GoF_Patterns.Behavior.Observer
{
    internal class IntSquareObserver : IMyObserver
    {
        ConcreteModel _model;
        int _square;

        public void SetNotifier(ConcreteModel model)
        {
            _model = model;
        }

        public void Square(int x)
        {
            _square = x * x;
        }

        public void Update()
        {
            Square(_model.X);
            Console.WriteLine($"Square is {_square}");
        }
    }
}
