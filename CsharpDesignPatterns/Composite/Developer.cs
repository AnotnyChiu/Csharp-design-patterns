using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Composite
{
    public class Developer : IEmployee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        
        public Developer(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public void Add(IEmployee employee)
        {
            // developer is the leaf node, which will not have sub emp
        }

        public IEmployee GetChild(int i)
        {
            // developer is the leaf node, which will not have sub emp
            return null;
        }

        public void Remove(IEmployee employee)
        {
            // developer is the leaf node, which will not have sub emp
        }

        public void Print()
        {
            Console.WriteLine("--------Developer----------");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary}");
        }

    }
}
