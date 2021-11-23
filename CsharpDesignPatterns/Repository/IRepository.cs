using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Repository
{
    public interface IRepository<T>
    {
        // notice we got generic type here
        void Add(T obj);
        void Remove(T obj);

        string GetAll();
    }
}
