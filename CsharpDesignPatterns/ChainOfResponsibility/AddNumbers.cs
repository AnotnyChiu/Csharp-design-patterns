using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.ChainOfResponsibility
{
    public class AddNumbers : IChain
    {
        // set a field for next object in chain
        private IChain _nextInChain;

        public void Calculate(Numbers request)
        {
            // check if this object can handle the issue
            if (request.Calculatioin == "add")
            {
                Console.WriteLine($"{request.Number1} + {request.Number2}"
                    + $" = {request.Number1 + request.Number2}");
            }
            else 
            {
                Console.WriteLine("Not add - pass it on");
                // passing data to next object set in the chain
                _nextInChain.Calculate(request);
            }
        }

        // set next chain will assign next object to take the data
        // and make connection btw these two object
        // but notice here chain order is not set yet
        // just like catch, the order of chain is implemented in concrete level
        public void SetNextChain(IChain nextChain)
        {
            _nextInChain = nextChain;
        }
    }
}
