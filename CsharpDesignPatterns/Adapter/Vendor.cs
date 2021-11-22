using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Adapter
{
    // this is the second independent program(app), for it retrieve data from db
    public class Vendor : IVendor
    {
        private int age;
        public void ConnectToDb(string connString, string customerId)
        {
            Console.WriteLine("Connect to db and fetch age of customer and set age");
            // hard code the age here for demo purpose
            this.age = 35;
        }

        public string PrintAge()
        {
            Console.WriteLine($"Age = {this.age}");
            return age + " ";
        }
    }
}
