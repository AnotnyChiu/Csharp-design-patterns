using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Bridge
{
    public class FullTimeEmp : IEmployee
    {
        public void EmpType()
        {
            Console.WriteLine("Full time employees");
        }
    }
}
