using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Adapter
{
    public static class TestAdapter
    {
        public static void AdapterMain() 
        {
            // system 1
            Console.WriteLine("case 1, sole client system: client.ConnectToFileSystem(\"1234\")");
            IClient client = new Client();
            string result = client.ConnectToFileSystem("1234");
            Console.WriteLine(result);
            Console.WriteLine("----------------------");

            // system 2
            Console.WriteLine("case 2, sole vendor system: vendor.ConnectToDb(\"OracleDb\", \"1234\");");
            IVendor vendor = new Vendor();
            vendor.ConnectToDb("OracleDb", "1234");
            Console.WriteLine(vendor.PrintAge());
            Console.WriteLine("----------------------");

            // adapted system
            Console.WriteLine("case 3, adapter system: adapter.ConnectToFileSystem(\"1234\");");
            Adapter adapter = new Adapter(vendor);
            string result2 = adapter.ConnectToFileSystem("1234");
            Console.WriteLine(result2);
            Console.WriteLine("----------------------");
            // so now it looks like a client system
            // but behind the scene it do the db stuff for you
        }
    }
}
