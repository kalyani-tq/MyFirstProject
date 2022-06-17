using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loos
{
    class AutoMorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");

            int num = int.Parse(Console.ReadLine());
            int count = 0;
            int temp = num;
            while(num>0)
            {
                count++;
                num = num / 10;

            }

           // Console.WriteLine(count);

            num = temp;
            int sq = num * num;
            int power = 1;
            for(int i=1;i<=count;i++)
            {
                power = power * 10;
            }

           // Console.WriteLine(sq+"  "+power);

            int end = sq % power;


            Console.WriteLine(sq+" "+" end= "+ end);

            if(end==num)
            {
                Console.WriteLine("automorphic");
            }
            else
            {
                Console.WriteLine("Not");
            }

            Console.WriteLine("/////////////////////////////");
            int c = 64;

            for(int i=1;i<5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    if(i%2==0)
                    {
                        Console.Write((char)(c+j));
                    }
                    else
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }


        }
    }
}
