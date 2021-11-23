using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Repository
{
    public class TextFileRepo : IRepository<Contact>
    {
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
