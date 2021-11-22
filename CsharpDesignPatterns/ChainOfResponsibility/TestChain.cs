using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.ChainOfResponsibility
{
    public static class TestChain
    {
        public static void ChainResMain() 
        { 
            // first create all objects put in the chain
            IChain obj1 = new AddNumbers();
            IChain obj2 = new SubtractNumbers();
            IChain obj3 = new MultiplyNumbers();

            // then set up chain order
            obj1.SetNextChain(obj2);
            obj2.SetNextChain(obj3);

            // set up the issue and pass into chain
            Numbers request = new Numbers(4, 2, "multiply");
            obj1.Calculate(request);
        }
    }
}
