using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Strategy
{
    public interface IDiscountStrategy
    {
        float GetDiscount();
    }
}
