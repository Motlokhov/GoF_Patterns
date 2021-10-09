namespace GoF_Patterns.Struct.Decorator
{
    internal class Decorator : Component
    {
        private Component _component;
        public Decorator(Component component)
        {
            _component = component;
        }

        public override void SomeAction()
        {
            _component.SomeAction();
        }
    }
}
