using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Strategy
{
    class DiwaliStreagty : IDiscountStrategy
    {
        public float GetDiscount() => 20;
    }

    class NewyearStreagty : IDiscountStrategy
    {
        public float GetDiscount() => 30;
    }

    class NoDiscountStreagty: IDiscountStrategy
    {
        public float GetDiscount() => 10;
    }
}
