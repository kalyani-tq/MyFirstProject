using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loos
{
    class BinaryToDecimal
    {

        static void Main(string[] args)
        {
           /* Console.WriteLine("enter the binary number");
            int num = int.Parse(Console.ReadLine());


            int sum = 0;
            int p = 0;
            while(num>0)
            {

                int r = num % 10;

                int power =(int)( Math.Pow(2, p));
                sum = sum + (power * r);
                num = num / 10;
                p++;

            }
            Console.WriteLine(sum);*/


            //2,5,10,17,26


            for(int i=1;i<=10;i++)
            {
                Console.Write(i*i+1+"  ");
            }

            //2,12,36,80
            Console.WriteLine();
            for(int i=1;i<=10;i++)
            {
                Console.Write(i*i+(i*i*i)+"  ");
            }
            Console.WriteLine();
            //0,3,8,15,24
        }
    }
}
