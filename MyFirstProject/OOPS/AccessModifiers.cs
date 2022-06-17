using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS
{
    public class AccessModifiers
    {

        private int x = 10;
        public int y = 300;

        protected int z = 45;



        static void Main(string[] args)
        {
            AccessModifiers a = new AccessModifiers();
            Console.WriteLine(a.x);//private only access in same class
            Console.WriteLine(a.y);
            Console.WriteLine(a.z);
        }
    }

    class ModifiersDemo :AccessModifiers
    {
        static void Main(string[] args)
        {
            AccessModifiers m = new AccessModifiers();
            //  Console.WriteLine(m.x);private can`t access out site the class
            Console.WriteLine(m.y);
            //  Console.WriteLine(m.z);

            ModifiersDemo d = new ModifiersDemo();
            Console.WriteLine(d.z);
        }
    }
}
