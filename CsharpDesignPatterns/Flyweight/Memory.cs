using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Flyweight
{
    public class Memory
    {
        // in dict it saves every charactor and it's property
        private Dictionary<char, FontProperty> _items = new Dictionary<char, FontProperty>();

        public FontProperty LookUp(char letter) 
        {
            if (!_items.ContainsKey(letter)) 
            {
                // font style will set default
                _items.Add(letter, new FontProperty(letter));
            }

            return _items[letter];
        }

        public int TotalObjectsMade() 
        {
            return _items.Count();
        }
    }
}
