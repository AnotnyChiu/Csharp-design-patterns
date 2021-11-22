using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Builder
{
    public interface IInsuranceBuilder
    {
        // insurance is built with these three components
        // while these three components will have different type
        // e.g. boat, cutocar, plane
        void BuildDriver();
        void BuildLocation();
        void BuildVehicle();

        Insurance GetInsurance();
    }
}
