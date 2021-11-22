using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Bridge
{
    public class ITDep : Department
    {
        public ITDep(IEmployee employee) : base(employee)
        {
        }

        public override void AssignEmployee()
        {
            Console.WriteLine("IT Dept assigned");
            _employee.EmpType();
        }
    }
}
