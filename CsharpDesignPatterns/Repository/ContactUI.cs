using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Repository
{
    public class ContactUI
    {
        // List<Contact> _repository;
        // use interface

        IRepository<Contact> _repo;

        public ContactUI(IRepository<Contact> repository)
        {
            _repo = repository;
        }

        public void Add(Contact obj) 
        {
            _repo.Add(obj);
        }

        public void Remove(Contact obj) 
        {
            _repo.Remove(obj);
        }

        public void PrintAll() 
        {
            Console.WriteLine(_repo.GetAll()); 
        }
    }
}
