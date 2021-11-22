using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Observer
{
    public static class TestObserver
    {
        public static void ObserverMain() 
        {
            // a blog(subject) will hold all the register users(observers)
            // and whenever a new article post by subject, all observers will be notified
            Blog blog = new Blog();

            // register users
            User user1 = new User(blog);
            User user2 = new User(blog);

            user1.PrintArticle(); // nothing printed

            // post article
            Console.WriteLine("Press any key to post a new article");
            Console.ReadLine();

            blog.PostNewArticle();

            // check new article
            Console.WriteLine("Press any key to see article in user1 and user2");
            Console.ReadLine();
            user1.PrintArticle();
            user2.PrintArticle();
        }
    }
}
