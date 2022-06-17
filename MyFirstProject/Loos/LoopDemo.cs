using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loos
{
    class LoopDemo
    {
        static void Main(string[] args)
        {
            //for(initilization;condition;increment/drcrement)
            //{
            //logic
            //}



            /*   int i;
               for(i=1;i<=5;i++)
               {
                   Console.WriteLine("Hello");
               }*/

            /* for(int i=1;i<=5;i++)
             {
                 Console.WriteLine(i);
             }*/


            /*int i = 1;
            for( ;i<=5;i++)
            {

            }*/

            /*  for(int i=1;i>=5;i++)
              {
                  Console.WriteLine(i);
              }*/

            /*  for(int i=1;i<=5;)
              {
                  Console.WriteLine(i);
              }*/
            /*
                        for(int i=5;i<=1;i--)
                        {
                            Console.WriteLine(i);
                        }*/

            /*   int i=1;

               for (i = 1; i <= 5; i++) ;
               {
                   Console.WriteLine(i);
               }*/

            /* for (int i = 1; i <= 5; i++)
             {
                 Console.WriteLine(i);
                 Console.WriteLine("Hi");
             }*/

            /*   for(int i=1; ;i++)
               {
                   Console.WriteLine("hi");
               }*/


            /*  for (; ; )
              {
                  Console.WriteLine("hii");
              }*/


            /*  for(int i=0;i<=10;i=i+2)
              {
                  Console.WriteLine(i);
              }*/

            //print even number
          /*  for (int i = 15; i <= 25; i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }*/
            //sum of number between 1 to 10

            int sum = 0;
            for(int i=1;i<=10;i++)
            {
                sum = sum + i;
            }

            Console.WriteLine(sum);

        }
    }
}
