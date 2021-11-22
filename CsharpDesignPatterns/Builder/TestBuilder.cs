using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Builder
{
    public static class TestBuilder
    {
        public static void BuilderMain() 
        {
            // Note: can implement a factory pattern here

            // client code

            // 1. create concrete Builder instance
            IInsuranceBuilder nyBenz = new AutoBuilder();

            // 2. pass to director to create insurance
            // tell the engineer to construct the unsurance using the specifications of the auto class
            EngineerDirector engineer = new EngineerDirector(nyBenz);

            engineer.BuildInsurance();

            Insurance result = engineer.ReturnInsurance();
            Console.WriteLine(result);
        }
    }
}
