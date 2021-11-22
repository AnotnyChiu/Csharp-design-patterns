using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Facade
{
    public class InsuranceFacade
    {
        // 1. integrate all the subsystems
        private readonly Car _car;
        private readonly Driver _driver;
        private readonly Location _location;

        // 2. inside the ctor pass the params required for all subsystems
        public InsuranceFacade(string vin, DateTime dob, string state)
        {
            _car = new Car(vin);
            _driver = new Driver(dob);
            _location = new Location(state);
        }

        // 3. combine function in sub system and create a higher level function
        // which client can easy understand what to do
        public void GetQuote() 
        {
            _car.CheckCarHistory();
            _car.CheckCarSafety();
            _driver.CheckDriverDetails();
            _location.CheckDriverConditions();
        }
    }
}
