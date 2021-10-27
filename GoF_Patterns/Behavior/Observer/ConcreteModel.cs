using System;

namespace GoF_Patterns.Behavior.Observer
{
    internal class ConcreteModel : Notifier
    {
        public ConcreteModel()
        {
            Console.WriteLine("Observer pattern");
        }

        int x;
        public int X
        {
            get => x; 
            set
            {
                x = value;
                Notify();
            }
        }

    }
}
