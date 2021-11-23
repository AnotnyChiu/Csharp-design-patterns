using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Repository
{
    public class InMemoryRepo : IRepository<Contact>
    {
        // 1. we say it clear that this repo store Contact
        // set a field for Contact
        List<Contact> _contacts = new List<Contact>();

        public void Add(Contact obj)
        {
            _contacts.Add(obj);
        }

        public void Remove(Contact obj)
        {
            _contacts.Remove(obj);
        }

        public string GetAll()
        {
            // return all contact as string
            string temp = "";
            foreach (var contact in _contacts)
            {
                temp += $"{contact}\n";
            }

            return temp;
        }
    }
}
