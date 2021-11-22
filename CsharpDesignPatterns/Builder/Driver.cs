using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Builder
{
    public class Driver
    {
        public string DriverName { get; set; }
        public int DriverAge { get; set; }

        public Driver(string name, int age)
        {
            DriverName = name;
            DriverAge = age;
        }

        public override string ToString()
        {
            return $"Name: {DriverName} | Age: {DriverAge}";
        }
    }
}
