using System.Collections.Generic;

namespace GoF_Patterns.Behavior.Observer
{
    internal abstract class Notifier
    {
        protected List<IMyObserver> _observers = new();

        public void AddObserver(IMyObserver observer)
        {
            _observers.Add(observer);
        }

        public void Notify()
        {
            _observers.ForEach((o) => o.Update());
        }
    }
}
