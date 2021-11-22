using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Facade
{
    public class Driver
    {
        public DateTime Dob { get; }

        public Driver(DateTime dob)
        {
            Dob = dob;
        }

        public void CheckDriverDetails() 
        {
            Console.WriteLine($"Check driver history: {Dob:d}");
            // notice: Dob:d is the simplified version of DateTime.ToString("d")
        }
    }
}
