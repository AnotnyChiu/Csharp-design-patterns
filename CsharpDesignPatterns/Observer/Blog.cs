using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Observer
{
    public class Blog : ISubject
    {
        private List<IObserver> _observersList;
        private bool _stateChanged;
        private string _blogArticle;

        public Blog()
        {
            _observersList = new List<IObserver>();
            _stateChanged = false;
        }

        public void PostNewArticle() 
        {
            _blogArticle = "Hey I'm learning design patterns right now!";
            _stateChanged = true;
            // brodcast the info
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            if (_stateChanged) 
            {
                foreach (var o in _observersList)
                {
                    o.UpdateUsers(_blogArticle);
                }
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observersList.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observersList.Remove(observer);
        }
    }
}
