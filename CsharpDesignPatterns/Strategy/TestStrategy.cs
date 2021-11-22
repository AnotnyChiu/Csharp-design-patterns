using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Strategy
{
    public static class TestStrategy
    {
        public static void StrategyMain()
        {
            // sub class can be passed into a super class
            Context context = new Context(new Add());
            int result = context.ExecuteStrategy(5, 4);
            Console.WriteLine(result);

            // It's something like dependency injection
            // which a interface has several sub implementations
            // then you create a abstract context class which take the interface as param
            // and then can choose from those sub implementation classes
            // by passing then into context's constructor

            // reassign context's strategy
            context = new Context(new Subtract());
            // notice! even though you call the same funciton name(from the interface)
            // you can let the user to choose from different strategies.
            int result2 = context.ExecuteStrategy(5, 4);
            Console.WriteLine(result2);
        }
    }
}
