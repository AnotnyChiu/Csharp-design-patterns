using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Flyweight
{
    public class FontProperty
    {
        private char _letter;
        private int _fontSize;
        private string _color;

        public FontProperty(char letter, int fontSize = 12, string color = "black")
        {
            _letter = letter;
            _fontSize = fontSize;
            _color = color;
        }

        public void Display() 
        {
            Console.WriteLine(_letter);
        }
    }
}
