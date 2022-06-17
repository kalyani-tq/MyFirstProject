using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inheritance
{

    interface Movable
    {
        public static int x = 10;
        static void s1()
        {
            Console.WriteLine("My");
        }
   public void s2()
        {
            Console.WriteLine("s2");
        }

    }
    class InterfaceDemo:Movable
    {
        void show()
        {
            Console.WriteLine(Movable.x);
        }
        static void Main(string[] args)
        {
                InterfaceDemo d = new InterfaceDemo();
            Movable.s1();
            Movable m = new InterfaceDemo();
            m.s2();



        }
    }
}
