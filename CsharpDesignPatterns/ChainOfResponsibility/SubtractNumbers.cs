using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.ChainOfResponsibility
{
    public class SubtractNumbers : IChain
    {
        private IChain _nextInChain;
        public void Calculate(Numbers request)
        {
            // check if this object can handle the issue
            if (request.Calculatioin == "subtract")
            {
                Console.WriteLine($"{request.Number1} - {request.Number2}"
                    + $" = {request.Number1 - request.Number2}");
            }
            else
            {
                Console.WriteLine("Not subtract - pass it on");
                // passing data to next object set in the chain
                _nextInChain.Calculate(request);
            }
        }

        public void SetNextChain(IChain nextChain)
        {
            _nextInChain = nextChain;
        }
    }
}
