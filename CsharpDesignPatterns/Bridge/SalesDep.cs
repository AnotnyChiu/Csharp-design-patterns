using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Bridge
{
    public class SalesDep : Department
    {
        public SalesDep(IEmployee employee) : base(employee)
        {
            // this class will have superclass filed
            // which is the _employee
            // so we just use the filed and don't have to specify here
        }
        public override void AssignEmployee()
        {
            Console.WriteLine("Sales dept assigned");
            _employee.EmpType();
        }
    }
}
