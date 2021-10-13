using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Behavior.Command
{
    internal class Reciever
    {
        public void PrintString(string str)
        {
            Console.WriteLine(str);
        }

        public void Beep()
        {
            Console.Beep();
        }
    }
}
