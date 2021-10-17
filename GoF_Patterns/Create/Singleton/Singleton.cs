using System.Threading;

namespace GoF_Patterns.Create.Singleton
{
    internal class Singleton
    {
        static volatile Singleton _instanse;

        public string  Value { get; set; }

        public static Singleton Instance 
        {
            get
            {
                if(_instanse is null)
                    Interlocked.CompareExchange(ref _instanse, new Singleton(), null);
                return _instanse;
            }
        }

        private Singleton()
        {

        }
    }
}
