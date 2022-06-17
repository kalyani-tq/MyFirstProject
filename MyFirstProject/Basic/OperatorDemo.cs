using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic
{
    class OperatorDemo
    {
        static void Main(string[] args)
        {
            /*     Console.WriteLine( 7+2-3*4/2);//3//12

                 Console.WriteLine( 5*3/4+2-2);//3
                 Console.WriteLine(51%9*2/2-1);//5
                 Console.WriteLine(7*6-2*(4+3*2/2));//28//
                 Console.WriteLine(81/9-9*9);//-72*/


            //<,>,<=,>=,==,!=

            int a = 3;
            int b = 4;
            int c = 4;
            /*   Console.WriteLine(a>b);
               Console.WriteLine(a<b);
               Console.WriteLine(a==b);
               Console.WriteLine(a!=b);*/

            //&&,||,!

            /*   Console.WriteLine((a<b) && (a>c));

               Console.WriteLine((a>b)||(c>a));
               Console.WriteLine(!(a>b));*/

            //+=,-=,*=,/=

            int x = 10;
            x += 2;
            //x=x+2;
            Console.WriteLine(x);//12

            x -= 3;
            Console.WriteLine(x);//7
            x *= 2;
            Console.WriteLine(x);






        }
    }
}
