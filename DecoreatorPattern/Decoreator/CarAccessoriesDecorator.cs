using DecoreatorPattern.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoreatorPattern.Decoreator
{
    public abstract class CarAccessoriesDecorator : ICar
    {
        private readonly ICar car;

        public CarAccessoriesDecorator(ICar car)
        {
            this.car = car;
        }

        public virtual string GetDescription() => this.car.GetDescription();

        public virtual double GetPrice() => this.car.GetPrice();
    }
}
