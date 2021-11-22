using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Strategy
{
    public class Multiply : IStrategy
    {
        public int Execute(int a, int b)
        {
            Console.WriteLine("Execute Multiply method's Execute()");
            return a * b;
        }
    }
}
