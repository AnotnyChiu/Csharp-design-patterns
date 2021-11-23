using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Flyweight
{
    public class Memory
    {
        // the memory class will save 26 lower and upper case characters
        // notice: "and there current font style!!"
        private Dictionary<char, FontProperty> _items = new Dictionary<char, FontProperty>();

        public FontProperty LookUp(char letter) 
        {
            if (!_items.ContainsKey(letter)) 
            {
                // if not exist yet then add to dictionary
                _items.Add(letter, new FontProperty(letter));
            }

            // or add it to the dictionary
            return _items[letter];
        }

        public int TotalObjectsMade() 
        {
            return _items.Count();
        }
    }
}
