using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.ChainOfResponsibility
{
    public class Numbers
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public string Calculatioin { get; set; }

        public Numbers(int num1, int num2, string cal)
        {
            Number1 = num1;
            Number2 = num2;
            Calculatioin = cal;
        }
    }
}
