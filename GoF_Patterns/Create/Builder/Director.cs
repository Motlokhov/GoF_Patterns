using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Create.Builder
{
    internal class Director
    {
        public Director()
        {
            Console.WriteLine("Builder pattern");
        }

        public void MakeSimpleCar(ICarBuilder builder)
        {
            builder.SetEngine("simple engine");
            builder.SetSeats(4);
        }

        public void MakeSportCar(ICarBuilder builder)
        {
            builder.SetSeats(2);
            builder.SetEngine("sport engine");
            builder.SetGps();
        }
    }
}
