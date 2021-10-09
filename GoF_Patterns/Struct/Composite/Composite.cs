using System;

namespace GoF_Patterns.Struct.Composite
{
    internal class Composite : IComponent
    {
        private IComponent[] _childs;
        public void Add(ILeaf leaf)
        {
            throw new NotImplementedException();
        }

        public void GetChild(int some_index)
        {
            throw new NotImplementedException();
        }

        public void Remove(ILeaf leaf)
        {
            throw new NotImplementedException();
        }

        public void SomeOperation()
        {
            throw new NotImplementedException();
        }
    }
}
