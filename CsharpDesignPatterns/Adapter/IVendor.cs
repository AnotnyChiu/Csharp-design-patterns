using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Adapter
{
    public interface IVendor
    {
        void ConnectToDb(string connString, string customerId);
        string PrintAge();
    }
}
