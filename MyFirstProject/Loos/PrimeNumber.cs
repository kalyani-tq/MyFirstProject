using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loos
{
    class PrimeNumber
    {


        static void Main(string[] args)
        {

            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());


            int count = 0;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                    break;

                }
            }


            if (count==0)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }


            /* bool isprime = true;
             for(int i=2;i<num;i++)
             {
                 if (num % i == 0)
                 {
                     isprime = false;
                 }
             }


             if(isprime==true)
             {
                 Console.WriteLine("Prime");
             }
             else
             {
                 Console.WriteLine("not prime");
             }*/

        }

    }
}
