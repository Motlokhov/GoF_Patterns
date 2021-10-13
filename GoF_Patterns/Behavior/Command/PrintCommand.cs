using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Behavior.Command
{
    internal class PrintCommand : ICommand
    {
        private Reciever _reciever;// получатель комманды
        private string _str;

        public PrintCommand(Reciever reciever, string str)
        {
            _str = str;
            _reciever = reciever;
        }

        public void Execute()
        {
            _reciever.PrintString(_str);
        }
    }
}
