using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Behavior.Mediator
{
    internal interface IMediator
    {
        void CollegueAction(ICollegue collegue);
        void CreateCollegues();
    }
}
