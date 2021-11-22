using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Adapter
{
    // this is the first independent program(app), retrieve data from text file
    public class Client : IClient
    {
        public string ConnectToFileSystem(string customerId)
        {
            Console.WriteLine("Connects to local .txt file an return age of the customer");
            return "34";
        }
    }
}
