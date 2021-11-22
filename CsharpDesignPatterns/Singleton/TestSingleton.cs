using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Singleton
{
    public static class TestSingleton
    {
        public static void SingletonMain()
        {
            // only the very first time will it create a new instance of logger
            // otherwise will just return the one created
            Logger singletonLogger = Logger.GetInstance();
            Logger singletonLogger2 = Logger.Instance;
            // test they're the same through the hash code
            Console.WriteLine(singletonLogger.GetHashCode());
            Console.WriteLine(singletonLogger2.GetHashCode());
        }
    }
}
