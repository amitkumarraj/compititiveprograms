using StrategyPattern.Model;
using StrategyPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Context
{
    class ItemContext
    {
        private readonly IDiscountStrategy _discountStrategy;
        public ItemContext(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public float GetItemNetPrice(Item item)
        {
            return item.Price - (item.Price * _discountStrategy.GetDiscount() / 100);
        }
    }
}
