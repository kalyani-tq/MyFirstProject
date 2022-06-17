using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS
{
    class StaticConstructor
    {

         static StaticConstructor()
        {
            Console.WriteLine("hiii");
        }

        StaticConstructor(int x)
        {
            Console.WriteLine("x="+x);
        }



        static void Main(string[] args)
        {
            StaticConstructor s = new StaticConstructor(400);

            StaticConstructor s1 = new StaticConstructor(34);
        }
    }
}
