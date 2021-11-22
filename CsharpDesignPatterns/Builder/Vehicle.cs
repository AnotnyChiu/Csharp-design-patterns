using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Builder
{
    public class Vehicle
    {
        public string VehicleName { get; set; }
        public int Year { get; set; }

        public Vehicle(string name, int year)
        {
            VehicleName = name;
            Year = year;
        }

        public override string ToString()
        {
            return $"Vehicle name: {VehicleName} | Year: {Year}";
        }
    }
}
