using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Flyweight
{
    public class Document
    {
        private Memory _memory = new Memory();
        private List<FontProperty> _letters = new List<FontProperty>();

        public void TypeLetter(char letter) 
        {
            FontProperty fontProp = _memory.LookUp(letter);
            _letters.Add(fontProp);
        }
    }
}
