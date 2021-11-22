using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Facade
{
    public class Car
    {
        public string Vin { get; }

        public Car(string vin)
        {
            Vin = vin;
        }

        public void CheckCarHistory() 
        {
            Console.WriteLine($"Check carfax report for {Vin}");
        }

        public void CheckCarSafety()
        {
            Console.WriteLine($"Check safety report for {Vin}");
        }
    }
}
