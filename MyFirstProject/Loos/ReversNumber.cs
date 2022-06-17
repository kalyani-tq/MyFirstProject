using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loos
{
    class ReversNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");

            int num = int.Parse(Console.ReadLine());

            int revers = 0;
            while(num>0)
            {
                int r = num % 10;
                revers = revers * 10 + r;
                num = num / 10;
            }
            Console.WriteLine(revers);

        }
    }
}
