using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Milk : PriceCalculatorDecorator
    {
        int _price = 5;
        public Milk(BeveragePriceCalculator decoratee) : base(decoratee)
        {
        }
        public override double CalculatePrice(Beverage beverage)
        {
            return _decoratee.CalculatePrice(beverage)+_price;
        }
    }
}
