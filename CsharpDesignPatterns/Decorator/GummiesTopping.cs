using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Decorator
{
    public class GummiesTopping : IceDecorator
    {
        public GummiesTopping(IceCream topping) : base(topping)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + _seperatpr + "Gummies";
        }

        public override double Cost()
        {
            return base.Cost() + 0.50;
        }
    }
}
