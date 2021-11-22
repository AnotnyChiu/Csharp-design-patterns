using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Facade
{
    public static class TestFacade
    {
        public static void FacadeMain() 
        {
            string vin = "EPF-7731";
            DateTime dob = DateTime.Parse("2020/09/01");
            string state = "Taipei";
            InsuranceFacade facade = new InsuranceFacade(vin, dob, state);
            facade.GetQuote();

            // mask the complex system and provide simplified interface for client
            // also it provide a level of protection which you take care of creating
            // all the subsystems safely and properly

        }
    }
}
