using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Observer
{
    public interface IObserver
    {
        // blogArticle - values the observer gets from the subject.

        void UpdateUsers(string blogArticle);
        void PrintArticle();
    }
}
