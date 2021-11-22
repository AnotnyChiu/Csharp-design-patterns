using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Composite
{
    public interface IEmployee
    {
        void Add(IEmployee employee);
        void Remove(IEmployee employee);
        IEmployee GetChild(int i);
        void Print();
    }
}
