using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Adapter
{
    public class Adapter : IClient
    {
        private readonly IVendor _vendor;
        // you want the class to look like "client"
        // since you're trying to apply vender system to client
        // the two interface are not compatible with each other now
        // since client only take customer id and vendor need also the connection string
        // the case is that our old system might have a GUI that only take customer id
        // and hard to modify to also take connection string
        // so we need to change the vendor to fit the client

        // * Steps
        // 1. adapter class inherit client interface
        // 2. set the field for instance of vendor
        // 3. create the ctor that let the vendor to be passed in

        public Adapter(IVendor vendor)
        {
            _vendor = vendor;
        }

        public string ConnectToFileSystem(string customerId)
        {
            // we get the connString from somewhere else
            string connString = "get from config file";
            _vendor.ConnectToDb(connString, customerId);

            // as you can see here, the main point is to make the param and return object compatible
            return _vendor.PrintAge();
        }
    }
}
