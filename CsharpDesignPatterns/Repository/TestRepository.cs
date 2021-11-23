using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Repository
{
    public static class TestRepository
    {
        public static void RepositoryMain() 
        {
            // can choose from various backend (db or text or...)
            var repository = new InMemoryRepo();
            // var repository = new TestFileRepo();

            ContactUI ui = new ContactUI(repository);

            Contact c1 = new Friend { Name = "Alex", PhoneNumber = "5555" };
            Contact c2 = new Work { Name = "Sara", Email = "sara@gmail.com" };

            ui.Add(c1);
            ui.Add(c2);
            ui.PrintAll();
        }
    }
}
