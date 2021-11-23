using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Flyweight
{
    public static class TestFlyweight
    {
        public static void FlyweightMain() 
        {
            // if need to create a lot of same objects, try using flyweight pattern

            // 1. create document object
            Document doc1 = new Document();
            ConsoleKeyInfo input;

            Console.WriteLine("Please type some words and press enter to continue");
            // notice: do....while loop
            // take continous key input, if not break by certain key
            do
            {
                input = Console.ReadKey();
                char x = input.KeyChar;
                doc1.TypeLetter(x);
            } while (input.Key != ConsoleKey.Enter);

            Console.WriteLine("\n");
            doc1.Process();
            doc1.Repost();
        }
    }
}
