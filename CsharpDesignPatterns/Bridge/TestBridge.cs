using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Bridge
{
    public static class TestBridge
    {
        public static void BridgeMain()
        {
            // fulltime sales
            Department d1 = new SalesDep(new FullTimeEmp());
            d1.AssignEmployee();
            // fulltime IT
            Department d2 = new ITDep(new FullTimeEmp());
            d2.AssignEmployee();
            //part time IT
            d2 = new ITDep(new PartTimeEmp());
            d2.AssignEmployee();
        }
    }
}
