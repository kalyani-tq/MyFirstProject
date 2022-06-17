using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loos
{
    class Power
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the base");

            int base1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the exponenet");
            int expo = int.Parse(Console.ReadLine());

            int power = 1;
            for(int i=1;i<=expo;i++)
            {
                power = power * base1;
            }

            Console.WriteLine(power);

        }
    }
}
