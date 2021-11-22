using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Bridge
{
    public class PartTimeEmp : IEmployee
    {
        public void EmpType()
        {
            Console.WriteLine("Part Time employees");
        }
    }
}
