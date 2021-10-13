using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Behavior.Command
{
    internal class CommandClient
    {
        public CommandClient()
        {
            Console.WriteLine("Command pattern");
        }

        public void FirstInvoke()
        {
            Reciever reciever = new();
            FirstInvoker invoker = new();
            invoker.SetCommand(new PrintCommand(reciever, "The command was stop."));
            invoker.Run();
        }

        public void SecondInvoke()
        {
            Reciever reciever = new Reciever();
            SecondInvoker invoker = new SecondInvoker();
            invoker.SetCommand(new BeepCommand(reciever));
            invoker.RunCommand();
        }

        public void ThirdInvoke()
        {
            Reciever reciever = new();
            SecondInvoker invoker = new SecondInvoker();
            invoker.SetCommand(new MacroCommand(new BeepCommand(reciever), new PrintCommand(reciever, "Double beep"), new BeepCommand(reciever)));
            invoker.RunCommand();
        }
    }
}
