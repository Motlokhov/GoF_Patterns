using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Behavior.Mediator
{
    internal class Light : ICollegue
    {
        private bool isEmiting = false;
        private IMediator _mediator;

        public Light(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Switch()
        {
            isEmiting = !isEmiting;
            Console.WriteLine($"Emiting is {isEmiting}");
        }

        public void Changed()
        {
            _mediator.CollegueAction(this);
        }
    }
}
