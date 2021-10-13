using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Behavior.Command
{
    internal class FirstInvoker
    {
        ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void Run()
        {
            _command.Execute();
        }
    }
}
