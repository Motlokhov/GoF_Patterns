using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Behavior.Iterator
{
    internal class ReverceIterator : IIterator
    {
        int[] _collection;

        public ReverceIterator(params int[] collection)
        {
            Console.WriteLine("Iterrator pattern");
            _collection = collection.ToArray();
        }

        public IEnumerator GetEnumerator()
        {
            return new ReverceEnumerator(_collection.ToArray());
        }
    }
}
