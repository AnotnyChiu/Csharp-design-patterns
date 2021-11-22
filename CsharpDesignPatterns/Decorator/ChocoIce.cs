using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Decorator
{
    public class ChocoIce : IceCream
    {
        public override double Cost()
        {
            return 2.00;
        }

        public override string GetDescription()
        {
            return "Chocolate ice creaam";
        }
    }
}
