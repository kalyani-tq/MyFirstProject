using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic
{
    class UnaryOperatorDemo
    {
        static void Main(string[] args)
        {
          //  int x = 10;
            /*      x++;//x=x+1;
                  Console.WriteLine(x);//11*/
            /* ++x;
             Console.WriteLine(x);*/


            /*Console.WriteLine(x++);
            Console.WriteLine(x);*/
          //  Console.WriteLine(++x);

            int a = 2;
            int b = 2;
            int c = 2;

            int x = ++a + b++ + c--;
            Console.WriteLine(x+" "+a+" "+b+" "+c);//7,3,3,1

            x = --b - ++a - ++c;
            Console.WriteLine(x + " " + a + " " + b+" "+c);//-4,4,2,2,

            x = a-- + b++ - c++ - a;
            Console.WriteLine(x + " " + a + " " + b+" "+c);//1,3,3,3//



            /* int x = ++a + ++b + a;
             Console.WriteLine(x+" "+a+" "+b);//9,3,3//

             x = --a + b++;
             Console.WriteLine(x + " " + a + " " + b);//5,2,4/
             x = a-- - --b - a;
             Console.WriteLine(x + " " + a + " " + b);//-2,1,3,
             x = ++a + --b + b++;
             Console.WriteLine(x + " " + a + " " + b);*///6,2,3

            /*int x = a++ + b++;
            Console.WriteLine(x+" "+a+" "+b);//4,3,3//6,3,3


            x = ++a + b++ + a;
            Console.WriteLine(x+" "+a+" "+b);//11//11,4,4*/


        }
    }
}
