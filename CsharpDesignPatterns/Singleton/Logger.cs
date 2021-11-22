using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Singleton
{
    public class Logger
    {
        // 3. static method can only access static data ot other static data
        private static Logger instance;

        // 1. make the ctor private
        private Logger()
        {

        }

        // 2. only this method can be accessed by outside
        public static Logger GetInstance() {
            if (instance == null) {
                instance = new Logger();
            }
            return instance;
        }

        // another way: using a property
        public static Logger Instance {
            get {
                if (instance == null) {
                    instance = new Logger();
                }
                return instance;
            }
        }
        // create or call the object: Var logger = Logger.Instance;
    }
}
