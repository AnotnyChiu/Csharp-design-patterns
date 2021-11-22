using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Builder
{
    // concrete class of Insurance builder
    public class BoatBuilder : IInsuranceBuilder
    {
        // field for insurance
        Insurance _insurance;

        public BoatBuilder()
        {
            _insurance = new Insurance();
        }

        public void BuildDriver()
        {
            Console.WriteLine("Enter Driver Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Driver Age");
            int age = int.Parse(Console.ReadLine());
            // code here may connect to some system
            _insurance.Driver = new Driver(name, age);
        }

        public void BuildLocation()
        {
            Console.WriteLine("Enter zipcode");
            string zip = Console.ReadLine();

            _insurance.Location = new Location(zip);
        }

        public void BuildVehicle()
        {
            Console.WriteLine("Enter Model Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Vehicle Year");
            int year = int.Parse(Console.ReadLine());

            _insurance.Vehicle = new Vehicle(name, year);
        }

        public Insurance GetInsurance()
        {
            // code to calculate cost of unsurance and set other properties of insurance
            // based on dirver, vehicle & location
            if (_insurance.Driver.DriverAge > 25)
            {
                _insurance.Price = 50.0m;
            }

            return _insurance;
        }
    }
}
