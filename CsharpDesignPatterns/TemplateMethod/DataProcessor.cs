using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.TemplateMethod
{
    // Remember! if a class has a abstract method, class itself also has to be abstract
    // and no one can create a obj from abstract class, this class is just addon of other classes
    public abstract class DataProcessor
    {
        public void ReadProcessSave()
        {
            // read and process is coming from subclass (who inherite it)
            ReadData();
            ProcessData();
            SaveData();
        }

        // since read and process is coming from sub class, so we can only 'imagine'
        // that there will be a ReadData() and ProcessData() here
        // to let the compiler happy
        // >> use 'abstract' method
        public abstract void ReadData();
        public abstract void ProcessData();

        public void SaveData()
        {
            Console.WriteLine("Data saved to db");
        }

        // Sum: in the 'template', you may have a wrapper method who deal with the order or
        // algorithms of other methods
        // and the 'common' methods will be concrete here, rather the methods that will be
        // different on sub classes will be defind as abstract method here
    }
}
