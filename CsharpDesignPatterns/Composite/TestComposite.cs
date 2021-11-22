using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Composite
{
    public static class TestComposite
    {
        public static void CompositeMain() 
        {
            IEmployee emp1 = new Developer("Emp ALex", 90000);
            IEmployee emp2 = new Developer("Emp Antony", 100000);

            IEmployee manager1 = new Manager("Manager John", 120000);

            manager1.Add(emp1);
            manager1.Add(emp2);

            IEmployee emp3 = new Developer("Emp Geroge", 80000);

            IEmployee director = new Manager("Director Sam", 200000);
            director.Add(emp3);
            director.Add(manager1);

            director.Print();
        }
    }
}
