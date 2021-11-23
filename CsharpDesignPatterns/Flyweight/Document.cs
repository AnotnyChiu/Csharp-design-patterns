using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Flyweight
{
    public class Document
    {
        // a document will store the memory instance and list of characters
        private Memory _memory = new Memory();
        private List<FontProperty> _letters = new List<FontProperty>();

        public void TypeLetter(char letter) 
        {
            FontProperty fontProp = _memory.LookUp(letter);
            _letters.Add(fontProp);
        }

        public void Process() 
        {
            // prints out the string
            foreach (var c in _letters)
            {
                c.Display();
            }
        }

        public void Repost() 
        {
            Console.WriteLine("Total items: " +
                $"{_memory.TotalObjectsMade()}");
        }
    }
}
