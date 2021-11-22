using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.TemplateMethod
{
    public static class TestTemplateMethod
    {
        public static void TestTemplate() { 
            ExcelFile obj = new ExcelFile();
            obj.ReadProcessSave();
            //obj.ReadData();
            //obj.ProcessData();
            //obj.SaveData();

            TextFile obj2 = new TextFile();
            obj.ReadProcessSave();
            //obj2.ReadData();
            //obj2.ProcessData();
            //obj2.SaveData();

        }
    }
}
