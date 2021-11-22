using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Decorator
{
    public class FudgeTopping : IceDecorator
    {
        public FudgeTopping(IceCream topping) : base(topping)
        {
        }

        // base on the icecream, add toppings to description and price
        public override string GetDescription()
        {
            return base.GetDescription() + _seperatpr + "Fudge";
        }

        public override double Cost()
        {
            return base.Cost() + 0.25;
        }
    }
}
