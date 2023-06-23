using DecoreatorPattern.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoreatorPattern.ConcreateComponent
{
    class EconomyCar : ICar
    {
        public string GetDescription() => "This is economy car ";

        public double GetPrice() => 300000.0;
    }
    class DeluxCar : ICar
    {
        public string GetDescription() => "This is delux car ";

        public double GetPrice() => 500000.0;
    }

    class LuxuryCar : ICar
    {
        public string GetDescription() => "This is luxury car ";

        public double GetPrice() => 900000.0;
    }
}
