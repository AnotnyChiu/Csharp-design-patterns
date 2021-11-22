using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Builder
{
    public class Insurance
    {
        public Driver Driver { get; set; }
        public Location Location { get; set; }
        public Vehicle Vehicle { get; set; }

        public decimal Price { get; set; }


        // notice: every object will have a "ToString" virtual method
        // which you can override it to create your custom printing
        public override string ToString()
        {
            return "Insurance has these values:\n" +
                $"Driver: {Driver}\n" +
                $"Location: {Location}\n" +
                $"Vehicle: {Vehicle}\n" +
                $"Price: {Price}\n";
        }
    }
}
