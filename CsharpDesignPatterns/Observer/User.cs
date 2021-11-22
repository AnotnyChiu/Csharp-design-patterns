using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Observer
{
    public class User : IObserver
    {
        private string _article;
        private ISubject _blog;

        public User(ISubject blog)
        {
            _blog = blog;
            // register the user
            blog.RegisterObserver(this);
        }

        public void PrintArticle()
        {
            Console.WriteLine($"Desktop browser: {_article}");
        }

        public void UpdateUsers(string blogArticle)
        {
            _article = blogArticle;
            Console.WriteLine("State change reported by Subject");
        }
    }
}
