using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Repository
{
    public class Contact
    {
        public string Name { get; set; }

        public override string ToString()
        {
            string temp = "";
            // notice the "is" keyword with "this">> to take this class
            // since subclass inherit this Contact class will be different
            // we are doing custom formatting here
            // notice!! : so the "this" keyword here might not be Contact
            // it can be either Friend or Work or any subclass inherit it

            if (this is Friend)
            {
                // notice here is doing casting
                // since Friend is the subclass of "this"
                // super class can be cast to subclass
                // it cast to 
                var a = (Friend)this; // >> this will cast to Friend (subclass)
                // var b = ((this)Friend); >> this will cast to Contact
                temp = $"Friend name: {Name} | Ph: {a.PhoneNumber}";
            }
            else if (this is Work) 
            {
                var a = (Work)this;
                temp = $"Work name: {Name} | Email: {a.Email}";
            }

            return temp;
        }
    }
}
