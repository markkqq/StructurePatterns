using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class PriceCalculatorDecorator : BeveragePriceCalculator
    {
        protected readonly BeveragePriceCalculator _decoratee;

        public PriceCalculatorDecorator(BeveragePriceCalculator decoratee)
        {
            _decoratee = decoratee;
        }
    }
}
