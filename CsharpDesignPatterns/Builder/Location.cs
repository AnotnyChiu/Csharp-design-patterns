using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Builder
{
    public class Location
    {
        public string Zip { get; set; }

        public Location(string zip)
        {
            Zip = zip;
        }

        public override string ToString()
        {
            return $"Zip: {Zip}";
        }
    }
}
