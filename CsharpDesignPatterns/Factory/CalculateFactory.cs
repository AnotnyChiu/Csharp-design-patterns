using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Factory
{
    public class CalculateFactory
    {
        // calculation can do several things base on type
        // so the return type here will be the interface rather than a concrete class
        public ICalculate Calculation(string type)
        {
            ICalculate obj;
            
            // conclusion: do not use dynamic type, 
            // rather using an interface to wrap up your classes, this make things robust
            switch (type.ToLowerInvariant())
            {
                case "add":
                    obj = new Add();
                    break;
                case "divide":
                    obj = new Divide();
                    break;
                case "subtract":
                    obj = new Subtract();
                    break;
                default:
                    Console.WriteLine("We don't do that");
                    obj = null;
                    break;
            }

            return obj;
        } 
    }
}
