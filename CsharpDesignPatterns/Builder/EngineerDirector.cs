using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Builder
{
    public class EngineerDirector
    {
        // the builder has the method to build each component
        // but the director class here will handle the order
        // or how to structure all the builder methods

        private IInsuranceBuilder _insuranceBuilder;

        public EngineerDirector(IInsuranceBuilder insuranceBuilder)
        {
            _insuranceBuilder = insuranceBuilder;
        }

        public Insurance ReturnInsurance() 
        {
            // use the builder class to create the insurance
            return _insuranceBuilder.GetInsurance();
        }

        public void BuildInsurance() 
        {
            _insuranceBuilder.BuildDriver();
            _insuranceBuilder.BuildLocation();
            _insuranceBuilder.BuildVehicle();
        }
    }
}
