using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Decorator
{
    public static class TestDecorator
    {
        public static void DecoratorMain() 
        {
            IceCream chocoIce = new ChocoIce();

            // update choco ice by assign to topping class
            // this update the price and description
            chocoIce = new NutsTopping(chocoIce);
            chocoIce = new GummiesTopping(chocoIce);
            // notice I can even add double topping
            chocoIce = new GummiesTopping(chocoIce);
            chocoIce = new NutsTopping(chocoIce);

            chocoIce.PrintDetails();
        }
    }
}
