using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.TemplateMethod
{
    public class ExcelFile : DataProcessor
    {
        // create a method to evoke methods in certain order
        // and since this method and the save to db method is the same
        // in either excel reader or text reader
        // we can defind a super class to make a higher level of abstraction
        // >> inherite the DataProcessor class here

        //public void ReadProcessSave() 
        //{
        //    ReadData();
        //    ProcessData();
        //    SaveData();
        //}

        // since it's abstract method in ancestor class, have to put 'override' keyword
        public override void ReadData()
        {
            Console.WriteLine("Data read from excel");
        }

        public override void ProcessData()
        {
            Console.WriteLine("Excel data processed");
        }

        //public void SaveData()
        //{
        //    Console.WriteLine("Data saved to db");
        //}
    }
}
