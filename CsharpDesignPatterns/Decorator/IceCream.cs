using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Decorator
{
    // for the base entity : create a abstract class
    public abstract class IceCream
    {
        public abstract string GetDescription();
        public abstract double Cost();

        public void PrintDetails() 
        {
            Console.WriteLine($"Cost: {Cost()}, Description: {GetDescription()}");
        }
    }
}
