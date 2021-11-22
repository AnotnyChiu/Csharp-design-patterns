using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Strategy
{
    public interface IStrategy
    {
        // strategy interface has the common abstract def of the method
        // and sub implementations will do different things
        int Execute(int a, int b);
    }
}
