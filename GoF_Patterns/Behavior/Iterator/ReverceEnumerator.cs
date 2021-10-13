using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Behavior.Iterator
{
    internal class ReverceEnumerator : IEnumerator
    {
        int currentIndex;
        int[] _collection;
        public ReverceEnumerator(int[] collection)
        {
            _collection = collection;
            Reset();
        }

        public object Current => _collection[currentIndex];

        public bool MoveNext()
        {
            if(currentIndex > 0)
            {
                currentIndex--;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            currentIndex = _collection.Length;
        }
    }
}
