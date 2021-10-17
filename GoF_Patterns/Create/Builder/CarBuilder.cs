using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Create.Builder
{
    internal class CarBuilder : ICarBuilder
    {
        private Car _car = new Car();

        public Car GetResult()
        {
            return _car;
        }

        public void SetEngine(string engine)
        {
            _car.Engine = engine;
        }

        public void SetGps()
        {
            _car.Gps = true;
        }

        public void SetSeats(int number)
        {
            _car.Seats = number;
        }
    }
}
