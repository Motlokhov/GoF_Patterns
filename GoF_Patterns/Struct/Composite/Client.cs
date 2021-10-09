namespace GoF_Patterns.Struct.Composite
{
    internal class Client
    {
        private IComponent _root;

        public void Do()
        {
            _root.SomeOperation();
        }
    }
}
