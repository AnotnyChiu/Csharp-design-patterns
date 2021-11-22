using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.TemplateMethod
{
    public class TextFile : DataProcessor
    {
        //public void ReadProcessSave()
        //{
        //    ReadData();
        //    ProcessData();
        //    SaveData();
        //}

        public override void ReadData()
        {
            Console.WriteLine("Data read from text");
        }

        public override void ProcessData()
        {
            Console.WriteLine("Text data processed");
        }

        //public void SaveData()
        //{
        //    Console.WriteLine("Data saved to db");
        //}
    }
}
