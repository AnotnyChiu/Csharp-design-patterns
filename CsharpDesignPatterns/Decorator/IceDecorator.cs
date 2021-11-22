using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Decorator
{
    public class IceDecorator : IceCream
    {
        // decorator class also implement same interface
        // also it got IceCream instance

        private IceCream _topping;

        // ctor get IceCream topping (which also implement Icecream class)
        public IceDecorator(IceCream topping)
        {
            _topping = topping;
        }

        protected string _seperatpr = ", ";

        public override double Cost()
        {
            return _topping.Cost();
        }

        public override string GetDescription()
        {
            return _topping.GetDescription();
        }
    }
}
