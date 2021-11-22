using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.ChainOfResponsibility
{
    public interface IChain
    {
        // either solves the problem or passes the data
        // to the next object in chain
        void Calculate(Numbers request);

        // defines the next object to receive the data
        // if this object cannot process it
        // notice here you can pass itself as params in it's method
        void SetNextChain(IChain nextChain);
    }
}
