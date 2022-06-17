using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS
{
    class ConstructorDemo
    {

        public ConstructorDemo()
        {
            Console.WriteLine("Default");
        }

        public ConstructorDemo(int x)
        {
            Console.WriteLine(x);
        }
        public void get()
        {

        }

        static void Main(string[] args)
        {
            ConstructorDemo c = new ConstructorDemo();

            ConstructorDemo c1 = new ConstructorDemo(567);
            
            c.get();


        }
    }
}
