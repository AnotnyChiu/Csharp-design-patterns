using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Facade
{
    public class Location
    {
        public string State { get; }

        public Location(string state)
        {
            State = state;
        }

        public void CheckDriverConditions() 
        {
            Console.WriteLine($"Get location information for {State}");
        }
    }
}
