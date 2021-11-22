using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Decorator
{
    public class VanillaIce : IceCream
    {
        public override double Cost()
        {
            return 1.00;
        }

        public override string GetDescription()
        {
            return "Vanilla ice cream";
        }
    }
}
