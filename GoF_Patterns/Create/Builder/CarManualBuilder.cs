using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Create.Builder
{
    internal class CarManualBuilder : ICarBuilder
    {
        private CarManual _carManual = new CarManual();
        public CarManual GetResult()
        {
            return _carManual;
        }

        public void SetEngine(string engine)
        {
            _carManual.EngineManual = $"Car have {engine}";
        }

        public void SetGps()
        {
            _carManual.GpsManual = "Car have GPS";
        }

        public void SetSeats(int number)
        {
            _carManual.SeatsManual = $"Car have {number} seats";
        }
    }
}
