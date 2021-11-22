using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Composite
{
    public class Manager : IEmployee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        // also a composite will have a list of emps
        private List<IEmployee> Employees = new List<IEmployee>();

        public Manager(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public void Add(IEmployee employee)
        {
            Employees.Add(employee);
        }

        public IEmployee GetChild(int i)
        {
            return Employees[i];
        }

        public void Remove(IEmployee employee)
        {
            Employees.Remove(employee);
        }

        public void Print()
        {
            Console.WriteLine("--------Manager----------");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary}");

            Console.WriteLine("--------Staff under---------");
            foreach (var e in Employees)
            {
                e.Print();
            }
        }

    }
}
