using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Factory
{
    public static class TestFactory
    {
        public static void FactoryMain() 
        {
            // create the instance of the factory
            // (which have the combination of the methods desired on different situations)
            Console.WriteLine("Please enter add, subtract, or divide");
            CalculateFactory fac = new CalculateFactory();
            // so here you won't know the class but only interface, until user decide what to do
            ICalculate obj = fac.Calculation(Console.ReadLine().ToLowerInvariant());
            Console.WriteLine("Please insert 1st num");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert 2nd num");
            int b = int.Parse(Console.ReadLine());
            obj.Calculate(a, b);
        }
    }
}
