using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Decorator
{
    // topping classes will implement decorator class
    public class NutsTopping : IceDecorator
    {
        public NutsTopping(IceCream topping): base(topping)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + _seperatpr + "Nuts";
        }

        public override double Cost()
        {
            return base.Cost() + 0.75;
        }
    }
}
