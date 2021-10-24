using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Behavior.Mediator
{
    internal class Button : ICollegue
    {
        IMediator _mediator;
        public Button(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Changed()
        {
            Console.WriteLine("Button was pressed");
            _mediator.CollegueAction(this);
        }
    }
}
