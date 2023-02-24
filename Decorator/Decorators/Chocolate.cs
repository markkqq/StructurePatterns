using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Chocolate : PriceCalculatorDecorator
    {
        int _price = 10;
        public Chocolate(BeveragePriceCalculator decoratee) : base(decoratee)
        {

        }
        public override double CalculatePrice(Beverage beverage)
        {
            return _decoratee.CalculatePrice(beverage)+_price;
        }
    }
}
