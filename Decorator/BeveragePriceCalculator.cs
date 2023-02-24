using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class BeveragePriceCalculator
    {
        public virtual double CalculatePrice(Beverage beverage)
        {
            return beverage.Price;
        }
    }
}
