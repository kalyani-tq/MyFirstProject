using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS
{
    class StaticVariableMethod
    {
        int x = 10;
        static int y = 30;

        void add()
        {
            Console.WriteLine("Addition is=="+(x+y));
            y = 1;
            Console.WriteLine("Add="+(x+y));
        }

        static void sum()
        {
            StaticVariableMethod m = new StaticVariableMethod();

            Console.WriteLine("Sum== "+(m.x+y));
            m.add();
           
        }




        static void Main(string[] args)
        {
            StaticVariableMethod s = new StaticVariableMethod();
           // s.add();
            //  StaticVariableMethod.sum();

            sum();

        }
    }
}
