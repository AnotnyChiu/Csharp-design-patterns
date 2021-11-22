using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.BasicConcepts
{
    class A
    {
        public virtual void MethodA()
        {
            Console.WriteLine("A - MA");
        }
    }

    class B : A {

        public override void MethodA()
        {
            Console.WriteLine("B - MA");
        }

        public void MethodB()
        {
            Console.WriteLine("B - MB");
        }
    }

    class Test {
        static void Submain() {
            A aobj = new A();
            B bobj = new B();
            bobj.MethodA();
            bobj.MethodB();

            // ---------------------------------------------------------
            // Superclass obj = new Subclass(); >> this is acceptable
            // ---------------------------------------------------------

            A obj1 = new B();
            // But remember, the instance now will be the instance of B
            // left side decide the behavior, while right side is the indeed value
            obj1.MethodA();
            // even though obj1 should have Method A and B, it can only access MehtodA since the
            // type will decide the behavior
            // !But notice the MethodA here will be the override MethodA since obj1 itself
            // is a B object!
            // once again left side only decide behavior, the real value and real method
            // id decide by the right hand side!!

            // but if using casting, then it sill can access Method B, because itself is a B
            A obj2 = new B();
            ((B)obj2).MethodB(); // notice how we do the casting here!
            (obj2 as B).MethodB(); // and here using as keyword!

            int x = 10;
            // just like this, int decide the behavior x can have,
            // but the value of x is a
        }
        
    
    
    }
}
