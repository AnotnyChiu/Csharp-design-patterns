using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Strategy
{
    public class Context
    {
        // context class will be plugged in various implementation of the IStrategy

        // notice whenever you have a interface property in class
        // you have to put it in ctor to be initialized
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public int ExecuteStrategy(int a, int b)
        {
            return _strategy.Execute(a, b);
        }
    }
}
