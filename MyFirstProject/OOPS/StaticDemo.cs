using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS
{
    class StaticDemo
    {
       static int count = 0;
        int x = 10;

        public StaticDemo()
        {
            count++;
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {


            //  Console.WriteLine(x);non static not access
            Console.WriteLine(count);
            StaticDemo d = new StaticDemo();
            StaticDemo d2 = new StaticDemo();
            StaticDemo d3 = new StaticDemo();
        }
    }
}
