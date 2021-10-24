using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Behavior.Mediator
{
    internal class ConcreteMediator : IMediator
    {
        public Button Button { get; private set; }
        public Light Light { get; private set; }

        public ConcreteMediator()
        {
            Console.WriteLine("Mediator pattern");
            CreateCollegues();
        }

        public void CollegueAction(ICollegue collegue)
        {
            if (Button.Equals(collegue))
                Light.Switch();
        }

        public void CreateCollegues()
        {
            Button = new Button(this);
            Light = new Light(this);
        }
    }
}
