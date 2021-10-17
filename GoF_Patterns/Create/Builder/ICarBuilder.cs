using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Create.Builder
{
    internal interface ICarBuilder
    {
        void SetSeats(int number);
        void SetEngine(string engine);
        void SetGps();
    }
}
