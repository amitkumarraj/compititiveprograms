using DecoreatorPattern.Component;
using DecoreatorPattern.Decoreator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoreatorPattern.ConcreateDecoreator
{
    public class BasicAccessories : CarAccessoriesDecorator
    {
        public BasicAccessories(ICar car) : base(car)
        {

        }

        public override double GetPrice() => base.GetPrice() + 5000;

        public override string GetDescription() => base.GetDescription() + " with basic accessories";
    }

    public class AdvanceAccessories : CarAccessoriesDecorator
    {
        public AdvanceAccessories(ICar car) : base(car)
        {

        }

        public override double GetPrice() => base.GetPrice() + 50000;

        public override string GetDescription() => base.GetDescription() + " with advance accessories";
    }

    public class SportAccessories : CarAccessoriesDecorator
    {
        public SportAccessories(ICar car) : base(car)
        {

        }

        public override double GetPrice() => base.GetPrice() + 200000;

        public override string GetDescription() => base.GetDescription() + " with sport accessories";
    }
}
