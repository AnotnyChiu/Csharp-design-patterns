using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Bridge
{
    public abstract class Department
    {
        // defind protected filed
        protected IEmployee _employee;

        public Department(IEmployee employee)
        {
            _employee = employee;
        }

        public abstract void AssignEmployee();
    }
}
