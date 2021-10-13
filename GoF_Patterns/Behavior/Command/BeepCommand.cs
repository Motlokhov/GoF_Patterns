using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Behavior.Command
{
    internal class BeepCommand : ICommand
    {
        Reciever _reciever;

        public BeepCommand(Reciever reciever)
        {
            _reciever = reciever;
        }

        public void Execute()
        {
            _reciever.Beep();
        }
    }
}
