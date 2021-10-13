using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Behavior.Command
{
    internal class MacroCommand : ICommand
    {
        ICommand[] _commands;

        public MacroCommand(params ICommand[] commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            foreach(ICommand command in _commands)
                command.Execute();
        }
    }
}
