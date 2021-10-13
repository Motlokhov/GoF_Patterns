using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Behavior.Command
{
    internal class SecondInvoker
    {
        ICommand _command;
        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void RunCommand()
        {
            _command.Execute();
        }
    }
}
